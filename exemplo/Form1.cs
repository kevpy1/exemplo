using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NetworkMonitorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateNetworkStatus(string message)
        {
            if (listBoxNetworkInfo.InvokeRequired)
            {
                listBoxNetworkInfo.Invoke(new Action<string>(UpdateNetworkStatus), message);
                return;
            }

            listBoxNetworkInfo.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");
            listBoxNetworkInfo.TopIndex = listBoxNetworkInfo.Items.Count - 1;
        }

        private void OnNetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            UpdateNetworkStatus($"Disponibilidade da rede alterada. Rede disponível: {e.IsAvailable}");
            UpdateNetworkStatus(e.IsAvailable);
        }

        private void UpdateNetworkStatus(bool isAvailable)
        {
            if (lblStatusRede.InvokeRequired)
            {
                lblStatusRede.Invoke(new Action<bool>(UpdateNetworkStatus), isAvailable);
                return;
            }

            if (isAvailable)
            {
                lblStatusRede.BackColor = Color.Green;
                lblStatusRede.Text = "ON";
            }
            else
            {
                lblStatusRede.BackColor = Color.Red;
                lblStatusRede.Text = "OFF";
            }
        }

        private void OnNetworkAddressChanged(object sender, EventArgs e)
        {
            UpdateNetworkStatus("Endereço de rede alterado. Interfaces atuais:");

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                UpdateNetworkStatus($"  {ni.Name} ({ni.NetworkInterfaceType}): {ni.OperationalStatus}");
            }
        }

        private void BTNLIGAR_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkChange.NetworkAvailabilityChanged += OnNetworkAvailabilityChanged;
                NetworkChange.NetworkAddressChanged += OnNetworkAddressChanged;

                UpdateNetworkStatus("Monitoramento de rede iniciado.");
                UpdateNetworkStatus($"Rede atualmente disponível: {NetworkInterface.GetIsNetworkAvailable()}");
                UpdateNetworkStatus(NetworkInterface.GetIsNetworkAvailable());

                BTNLIGAR.Enabled = false;
                BTNDESLIGAR.Enabled = true;

                // Atualiza status do programa
                lblStatusPrograma.BackColor = Color.Green;
                lblStatusPrograma.Text = "ON";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar monitoramento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNDESLIGAR_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkChange.NetworkAvailabilityChanged -= OnNetworkAvailabilityChanged;
                NetworkChange.NetworkAddressChanged -= OnNetworkAddressChanged;

                UpdateNetworkStatus("Monitoramento de rede parado.");

                BTNLIGAR.Enabled = true;
                BTNDESLIGAR.Enabled = false;

                // Atualiza status do programa
                lblStatusPrograma.BackColor = Color.Red;
                lblStatusPrograma.Text = "OFF";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao parar monitoramento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            string host = txtHostToPing.Text.Trim();
            if (string.IsNullOrEmpty(host))
            {
                MessageBox.Show("Por favor, digite um host para testar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (Ping ping = new Ping())
                {
                    UpdateNetworkStatus($"Testando conexão com {host}...");

                    PingReply reply = await ping.SendPingAsync(host);
                    UpdateNetworkStatus($"Status do ping para ({host}): {reply.Status}");

                    if (reply.Status == IPStatus.Success)
                    {
                        UpdateNetworkStatus($"  Endereço: {reply.Address}");
                        UpdateNetworkStatus($"  Tempo de resposta: {reply.RoundtripTime}ms");
                        UpdateNetworkStatus($"  TTL: {reply.Options?.Ttl ?? 0}");
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateNetworkStatus($"Erro ao pingar {host}: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            NetworkChange.NetworkAvailabilityChanged -= OnNetworkAvailabilityChanged;
            NetworkChange.NetworkAddressChanged -= OnNetworkAddressChanged;
        }

        private void TXTSTATUS_Click(object sender, EventArgs e)
        {
            // Não é necessário implementação aqui
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTNDESLIGAR.Enabled = false;
            UpdateNetworkStatus("Aplicativo iniciado. Clique em 'Ligar Monitor' para começar.");

            // Configura status inicial
            lblStatusPrograma.BackColor = Color.Red;
            lblStatusPrograma.Text = "OFF";
            lblStatusRede.BackColor = Color.Red;
            lblStatusRede.Text = "OFF";
        }
    }
}
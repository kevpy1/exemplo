namespace NetworkMonitorApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNLIGAR = new System.Windows.Forms.Button();
            this.BTNDESLIGAR = new System.Windows.Forms.Button();
            this.TXTSTATUS = new System.Windows.Forms.Label();
            this.listBoxNetworkInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostToPing = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.lblStatusPrograma = new System.Windows.Forms.Label();
            this.lblStatusRede = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNLIGAR
            // 
            this.BTNLIGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNLIGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLIGAR.Location = new System.Drawing.Point(542, 346);
            this.BTNLIGAR.Name = "BTNLIGAR";
            this.BTNLIGAR.Size = new System.Drawing.Size(150, 40);
            this.BTNLIGAR.TabIndex = 0;
            this.BTNLIGAR.Text = "LIGAR MONITOR";
            this.BTNLIGAR.UseVisualStyleBackColor = false;
            this.BTNLIGAR.Click += new System.EventHandler(this.BTNLIGAR_Click);
            // 
            // BTNDESLIGAR
            // 
            this.BTNDESLIGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNDESLIGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDESLIGAR.Location = new System.Drawing.Point(316, 346);
            this.BTNDESLIGAR.Name = "BTNDESLIGAR";
            this.BTNDESLIGAR.Size = new System.Drawing.Size(150, 40);
            this.BTNDESLIGAR.TabIndex = 1;
            this.BTNDESLIGAR.Text = "DESLIGAR MONITOR";
            this.BTNDESLIGAR.UseVisualStyleBackColor = false;
            this.BTNDESLIGAR.Click += new System.EventHandler(this.BTNDESLIGAR_Click);
            // 
            // TXTSTATUS
            // 
            this.TXTSTATUS.AutoSize = true;
            this.TXTSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSTATUS.Location = new System.Drawing.Point(342, 20);
            this.TXTSTATUS.Name = "TXTSTATUS";
            this.TXTSTATUS.Size = new System.Drawing.Size(192, 20);
            this.TXTSTATUS.TabIndex = 2;
            this.TXTSTATUS.Text = "MONITOR DE REDE";
            // 
            // listBoxNetworkInfo
            // 
            this.listBoxNetworkInfo.FormattingEnabled = true;
            this.listBoxNetworkInfo.HorizontalScrollbar = true;
            this.listBoxNetworkInfo.Location = new System.Drawing.Point(30, 60);
            this.listBoxNetworkInfo.Name = "listBoxNetworkInfo";
            this.listBoxNetworkInfo.Size = new System.Drawing.Size(740, 225);
            this.listBoxNetworkInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host para pingar:";
            // 
            // txtHostToPing
            // 
            this.txtHostToPing.Location = new System.Drawing.Point(134, 307);
            this.txtHostToPing.Name = "txtHostToPing";
            this.txtHostToPing.Size = new System.Drawing.Size(150, 20);
            this.txtHostToPing.TabIndex = 5;
            this.txtHostToPing.Text = "stackoverflow.com";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(134, 333);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(150, 30);
            this.btnPing.TabIndex = 6;
            this.btnPing.Text = "Testar Conexão";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // lblStatusPrograma
            // 
            this.lblStatusPrograma.BackColor = System.Drawing.Color.Red;
            this.lblStatusPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPrograma.ForeColor = System.Drawing.Color.White;
            this.lblStatusPrograma.Location = new System.Drawing.Point(700, 310);
            this.lblStatusPrograma.Name = "lblStatusPrograma";
            this.lblStatusPrograma.Size = new System.Drawing.Size(70, 23);
            this.lblStatusPrograma.TabIndex = 7;
            this.lblStatusPrograma.Text = "OFF";
            this.lblStatusPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusRede
            // 
            this.lblStatusRede.BackColor = System.Drawing.Color.Red;
            this.lblStatusRede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusRede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusRede.ForeColor = System.Drawing.Color.White;
            this.lblStatusRede.Location = new System.Drawing.Point(700, 340);
            this.lblStatusRede.Name = "lblStatusRede";
            this.lblStatusRede.Size = new System.Drawing.Size(70, 23);
            this.lblStatusRede.TabIndex = 8;
            this.lblStatusRede.Text = "OFF";
            this.lblStatusRede.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status Programa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status Rede:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatusRede);
            this.Controls.Add(this.lblStatusPrograma);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtHostToPing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNetworkInfo);
            this.Controls.Add(this.TXTSTATUS);
            this.Controls.Add(this.BTNDESLIGAR);
            this.Controls.Add(this.BTNLIGAR);
            this.Name = "Form1";
            this.Text = "Monitor de Rede";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNLIGAR;
        private System.Windows.Forms.Button BTNDESLIGAR;
        private System.Windows.Forms.Label TXTSTATUS;
        private System.Windows.Forms.ListBox listBoxNetworkInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostToPing;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label lblStatusPrograma;
        private System.Windows.Forms.Label lblStatusRede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
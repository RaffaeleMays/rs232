namespace WindowsFormsApp1
{
    partial class frmMainServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbStato = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.pnlSuspend = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.txtCronologia = new System.Windows.Forms.TextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.btnSospendi = new System.Windows.Forms.Button();
            this.btnRispristino = new System.Windows.Forms.Button();
            this.grbComandi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.srlPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrSuspend = new System.Windows.Forms.Timer(this.components);
            this.grbStato.SuspendLayout();
            this.grbComandi.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStatus
            // 
            this.PanelStatus.Location = new System.Drawing.Point(146, 39);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(30, 18);
            this.PanelStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Stato Server:";
            // 
            // grbStato
            // 
            this.grbStato.Controls.Add(this.label3);
            this.grbStato.Controls.Add(this.label2);
            this.grbStato.Controls.Add(this.label1);
            this.grbStato.Controls.Add(this.pnlDown);
            this.grbStato.Controls.Add(this.pnlSuspend);
            this.grbStato.Controls.Add(this.pnlUp);
            this.grbStato.Location = new System.Drawing.Point(357, 12);
            this.grbStato.Name = "grbStato";
            this.grbStato.Size = new System.Drawing.Size(217, 81);
            this.grbStato.TabIndex = 2;
            this.grbStato.TabStop = false;
            this.grbStato.Text = "Stato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOWN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SUSPEND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UP";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.Red;
            this.pnlDown.Location = new System.Drawing.Point(6, 54);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(15, 10);
            this.pnlDown.TabIndex = 3;
            // 
            // pnlSuspend
            // 
            this.pnlSuspend.BackColor = System.Drawing.Color.Yellow;
            this.pnlSuspend.Location = new System.Drawing.Point(6, 38);
            this.pnlSuspend.Name = "pnlSuspend";
            this.pnlSuspend.Size = new System.Drawing.Size(15, 10);
            this.pnlSuspend.TabIndex = 2;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlUp.Location = new System.Drawing.Point(6, 22);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(15, 10);
            this.pnlUp.TabIndex = 1;
            // 
            // txtCronologia
            // 
            this.txtCronologia.Location = new System.Drawing.Point(12, 210);
            this.txtCronologia.Multiline = true;
            this.txtCronologia.Name = "txtCronologia";
            this.txtCronologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCronologia.Size = new System.Drawing.Size(562, 228);
            this.txtCronologia.TabIndex = 3;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(28, 30);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(75, 23);
            this.btnAvvia.TabIndex = 4;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // btnSospendi
            // 
            this.btnSospendi.Location = new System.Drawing.Point(207, 30);
            this.btnSospendi.Name = "btnSospendi";
            this.btnSospendi.Size = new System.Drawing.Size(75, 23);
            this.btnSospendi.TabIndex = 5;
            this.btnSospendi.Text = "Sospendi";
            this.btnSospendi.UseVisualStyleBackColor = true;
            this.btnSospendi.Click += new System.EventHandler(this.btnSospendi_Click);
            // 
            // btnRispristino
            // 
            this.btnRispristino.Location = new System.Drawing.Point(386, 30);
            this.btnRispristino.Name = "btnRispristino";
            this.btnRispristino.Size = new System.Drawing.Size(75, 23);
            this.btnRispristino.TabIndex = 6;
            this.btnRispristino.Text = "Ripristina";
            this.btnRispristino.UseVisualStyleBackColor = true;
            this.btnRispristino.Click += new System.EventHandler(this.btnRispristino_Click);
            // 
            // grbComandi
            // 
            this.grbComandi.Controls.Add(this.btnRispristino);
            this.grbComandi.Controls.Add(this.btnSospendi);
            this.grbComandi.Controls.Add(this.btnAvvia);
            this.grbComandi.Location = new System.Drawing.Point(21, 99);
            this.grbComandi.Name = "grbComandi";
            this.grbComandi.Size = new System.Drawing.Size(553, 71);
            this.grbComandi.TabIndex = 7;
            this.grbComandi.TabStop = false;
            this.grbComandi.Text = "Comandi Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cronologia Comandi ";
            // 
            // srlPort1
            // 
            this.srlPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.srlPort1_DataReceived);
            // 
            // tmrSuspend
            // 
            this.tmrSuspend.Interval = 1000;
            this.tmrSuspend.Tick += new System.EventHandler(this.tmrSuspend_Tick);
            // 
            // frmMainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbComandi);
            this.Controls.Add(this.txtCronologia);
            this.Controls.Add(this.grbStato);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.PanelStatus);
            this.Name = "frmMainServer";
            this.Text = "SERVER.msc";
            this.Load += new System.EventHandler(this.frmMainServer_Load);
            this.grbStato.ResumeLayout(false);
            this.grbStato.PerformLayout();
            this.grbComandi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbStato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Panel pnlSuspend;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.TextBox txtCronologia;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Button btnSospendi;
        private System.Windows.Forms.Button btnRispristino;
        private System.Windows.Forms.GroupBox grbComandi;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort srlPort1;
        private System.Windows.Forms.Timer tmrSuspend;
    }
}


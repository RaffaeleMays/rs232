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
            this.PnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbStato = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.pnlSuspend = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.btnSospendi = new System.Windows.Forms.Button();
            this.btnRispristino = new System.Windows.Forms.Button();
            this.grbComandi = new System.Windows.Forms.GroupBox();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.srlPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrSuspend = new System.Windows.Forms.Timer(this.components);
            this.tmrRicevi = new System.Windows.Forms.Timer(this.components);
            this.lblCronologia = new System.Windows.Forms.ListBox();
            this.grpCronologia = new System.Windows.Forms.GroupBox();
            this.grbConnect = new System.Windows.Forms.GroupBox();
            this.cmbCOMPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rdbUp = new System.Windows.Forms.RadioButton();
            this.rdbDown = new System.Windows.Forms.RadioButton();
            this.grbStato.SuspendLayout();
            this.grbComandi.SuspendLayout();
            this.grpCronologia.SuspendLayout();
            this.grbConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlStatus
            // 
            this.PnlStatus.Location = new System.Drawing.Point(206, 45);
            this.PnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.PnlStatus.Name = "PnlStatus";
            this.PnlStatus.Size = new System.Drawing.Size(40, 22);
            this.PnlStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(27, 36);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(168, 30);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Server Status:";
            // 
            // grbStato
            // 
            this.grbStato.Controls.Add(this.label3);
            this.grbStato.Controls.Add(this.label2);
            this.grbStato.Controls.Add(this.label1);
            this.grbStato.Controls.Add(this.pnlDown);
            this.grbStato.Controls.Add(this.lblStatus);
            this.grbStato.Controls.Add(this.PnlStatus);
            this.grbStato.Controls.Add(this.pnlSuspend);
            this.grbStato.Controls.Add(this.pnlUp);
            this.grbStato.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStato.Location = new System.Drawing.Point(13, 99);
            this.grbStato.Margin = new System.Windows.Forms.Padding(4);
            this.grbStato.Name = "grbStato";
            this.grbStato.Padding = new System.Windows.Forms.Padding(4);
            this.grbStato.Size = new System.Drawing.Size(554, 100);
            this.grbStato.TabIndex = 2;
            this.grbStato.TabStop = false;
            this.grbStato.Text = "Stato";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOWN";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "SUSPEND";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "UP";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.Red;
            this.pnlDown.Location = new System.Drawing.Point(374, 65);
            this.pnlDown.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(20, 12);
            this.pnlDown.TabIndex = 3;
            // 
            // pnlSuspend
            // 
            this.pnlSuspend.BackColor = System.Drawing.Color.Yellow;
            this.pnlSuspend.Location = new System.Drawing.Point(374, 46);
            this.pnlSuspend.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuspend.Name = "pnlSuspend";
            this.pnlSuspend.Size = new System.Drawing.Size(20, 12);
            this.pnlSuspend.TabIndex = 2;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlUp.Location = new System.Drawing.Point(374, 26);
            this.pnlUp.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(20, 12);
            this.pnlUp.TabIndex = 1;
            // 
            // btnAvvia
            // 
            this.btnAvvia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvvia.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvvia.Location = new System.Drawing.Point(37, 37);
            this.btnAvvia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(100, 28);
            this.btnAvvia.TabIndex = 4;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            this.btnAvvia.MouseEnter += new System.EventHandler(this.btnAvvia_MouseEnter);
            this.btnAvvia.MouseLeave += new System.EventHandler(this.btnAvvia_MouseLeave);
            // 
            // btnSospendi
            // 
            this.btnSospendi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSospendi.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSospendi.Location = new System.Drawing.Point(219, 37);
            this.btnSospendi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSospendi.Name = "btnSospendi";
            this.btnSospendi.Size = new System.Drawing.Size(100, 28);
            this.btnSospendi.TabIndex = 5;
            this.btnSospendi.Text = "Sospendi";
            this.btnSospendi.UseVisualStyleBackColor = true;
            this.btnSospendi.Click += new System.EventHandler(this.btnSospendi_Click);
            this.btnSospendi.MouseEnter += new System.EventHandler(this.btnSospendi_MouseEnter);
            this.btnSospendi.MouseLeave += new System.EventHandler(this.btnSospendi_MouseLeave);
            // 
            // btnRispristino
            // 
            this.btnRispristino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRispristino.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRispristino.Location = new System.Drawing.Point(416, 37);
            this.btnRispristino.Margin = new System.Windows.Forms.Padding(4);
            this.btnRispristino.Name = "btnRispristino";
            this.btnRispristino.Size = new System.Drawing.Size(100, 28);
            this.btnRispristino.TabIndex = 6;
            this.btnRispristino.Text = "Ripristina";
            this.btnRispristino.UseVisualStyleBackColor = true;
            this.btnRispristino.Click += new System.EventHandler(this.btnRispristino_Click);
            this.btnRispristino.MouseEnter += new System.EventHandler(this.btnRispristino_MouseEnter);
            this.btnRispristino.MouseLeave += new System.EventHandler(this.btnRispristino_MouseLeave);
            // 
            // grbComandi
            // 
            this.grbComandi.Controls.Add(this.lblCountDown);
            this.grbComandi.Controls.Add(this.btnRispristino);
            this.grbComandi.Controls.Add(this.btnSospendi);
            this.grbComandi.Controls.Add(this.btnAvvia);
            this.grbComandi.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbComandi.Location = new System.Drawing.Point(13, 208);
            this.grbComandi.Margin = new System.Windows.Forms.Padding(4);
            this.grbComandi.Name = "grbComandi";
            this.grbComandi.Padding = new System.Windows.Forms.Padding(4);
            this.grbComandi.Size = new System.Drawing.Size(554, 87);
            this.grbComandi.TabIndex = 7;
            this.grbComandi.TabStop = false;
            this.grbComandi.Text = "Comandi Server";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Location = new System.Drawing.Point(326, 43);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(16, 18);
            this.lblCountDown.TabIndex = 7;
            this.lblCountDown.Text = "0";
            // 
            // tmrSuspend
            // 
            this.tmrSuspend.Interval = 1000;
            this.tmrSuspend.Tick += new System.EventHandler(this.tmrSuspend_Tick);
            // 
            // tmrRicevi
            // 
            this.tmrRicevi.Tick += new System.EventHandler(this.tmrRicevi_Tick);
            // 
            // lblCronologia
            // 
            this.lblCronologia.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronologia.FormattingEnabled = true;
            this.lblCronologia.ItemHeight = 20;
            this.lblCronologia.Location = new System.Drawing.Point(6, 30);
            this.lblCronologia.Name = "lblCronologia";
            this.lblCronologia.ScrollAlwaysVisible = true;
            this.lblCronologia.Size = new System.Drawing.Size(541, 124);
            this.lblCronologia.TabIndex = 9;
            // 
            // grpCronologia
            // 
            this.grpCronologia.Controls.Add(this.lblCronologia);
            this.grpCronologia.Location = new System.Drawing.Point(13, 302);
            this.grpCronologia.Name = "grpCronologia";
            this.grpCronologia.Size = new System.Drawing.Size(556, 165);
            this.grpCronologia.TabIndex = 10;
            this.grpCronologia.TabStop = false;
            this.grpCronologia.Text = "Cronologia";
            // 
            // grbConnect
            // 
            this.grbConnect.Controls.Add(this.rdbDown);
            this.grbConnect.Controls.Add(this.rdbUp);
            this.grbConnect.Controls.Add(this.btnConnect);
            this.grbConnect.Controls.Add(this.cmbCOMPorts);
            this.grbConnect.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConnect.Location = new System.Drawing.Point(19, 12);
            this.grbConnect.Name = "grbConnect";
            this.grbConnect.Size = new System.Drawing.Size(548, 80);
            this.grbConnect.TabIndex = 11;
            this.grbConnect.TabStop = false;
            this.grbConnect.Text = "Connect";
            // 
            // cmbCOMPorts
            // 
            this.cmbCOMPorts.FormattingEnabled = true;
            this.cmbCOMPorts.Location = new System.Drawing.Point(31, 33);
            this.cmbCOMPorts.Name = "cmbCOMPorts";
            this.cmbCOMPorts.Size = new System.Drawing.Size(121, 25);
            this.cmbCOMPorts.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(200, 30);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(136, 28);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // rdbUp
            // 
            this.rdbUp.AutoSize = true;
            this.rdbUp.Location = new System.Drawing.Point(368, 33);
            this.rdbUp.Name = "rdbUp";
            this.rdbUp.Size = new System.Drawing.Size(48, 22);
            this.rdbUp.TabIndex = 9;
            this.rdbUp.TabStop = true;
            this.rdbUp.Text = "Up";
            this.rdbUp.UseVisualStyleBackColor = true;
            // 
            // rdbDown
            // 
            this.rdbDown.AutoSize = true;
            this.rdbDown.Location = new System.Drawing.Point(429, 33);
            this.rdbDown.Name = "rdbDown";
            this.rdbDown.Size = new System.Drawing.Size(69, 22);
            this.rdbDown.TabIndex = 10;
            this.rdbDown.TabStop = true;
            this.rdbDown.Text = "Down";
            this.rdbDown.UseVisualStyleBackColor = true;
            // 
            // frmMainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(585, 475);
            this.Controls.Add(this.grbConnect);
            this.Controls.Add(this.grpCronologia);
            this.Controls.Add(this.grbComandi);
            this.Controls.Add(this.grbStato);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainServer";
            this.Text = "SERVER.msc";
            this.Load += new System.EventHandler(this.frmMainServer_Load);
            this.grbStato.ResumeLayout(false);
            this.grbStato.PerformLayout();
            this.grbComandi.ResumeLayout(false);
            this.grbComandi.PerformLayout();
            this.grpCronologia.ResumeLayout(false);
            this.grbConnect.ResumeLayout(false);
            this.grbConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbStato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Panel pnlSuspend;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Button btnSospendi;
        private System.Windows.Forms.Button btnRispristino;
        private System.Windows.Forms.GroupBox grbComandi;
        private System.IO.Ports.SerialPort srlPort1;
        private System.Windows.Forms.Timer tmrSuspend;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer tmrRicevi;
        private System.Windows.Forms.ListBox lblCronologia;
        private System.Windows.Forms.GroupBox grpCronologia;
        private System.Windows.Forms.GroupBox grbConnect;
        private System.Windows.Forms.RadioButton rdbDown;
        private System.Windows.Forms.RadioButton rdbUp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbCOMPorts;
    }
}


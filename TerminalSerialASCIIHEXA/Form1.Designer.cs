namespace WinTeste
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bEnviar = new System.Windows.Forms.Button();
            this.tbEnviar = new System.Windows.Forms.TextBox();
            this.bConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPorta = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.gbComunica = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAutoLimpa = new System.Windows.Forms.CheckBox();
            this.cbLF = new System.Windows.Forms.CheckBox();
            this.cbCR = new System.Windows.Forms.CheckBox();
            this.bEnviarH = new System.Windows.Forms.Button();
            this.bLimpar = new System.Windows.Forms.Button();
            this.tbEnviarH = new System.Windows.Forms.TextBox();
            this.gbMotor = new System.Windows.Forms.GroupBox();
            this.cbHexaEspaço = new System.Windows.Forms.CheckBox();
            this.cbSom = new System.Windows.Forms.CheckBox();
            this.bLimpar2 = new System.Windows.Forms.Button();
            this.tbRecebidoH = new System.Windows.Forms.TextBox();
            this.tbRecebido = new System.Windows.Forms.TextBox();
            this.tbEnviado = new System.Windows.Forms.TextBox();
            this.tbEnviadoH = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bT3 = new System.Windows.Forms.Button();
            this.bT4 = new System.Windows.Forms.Button();
            this.bT1 = new System.Windows.Forms.Button();
            this.bT2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbT4 = new System.Windows.Forms.TextBox();
            this.tbT3 = new System.Windows.Forms.TextBox();
            this.tbT2 = new System.Windows.Forms.TextBox();
            this.tbT1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEnter = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbSetup.SuspendLayout();
            this.gbComunica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMotor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort1
            // 
            this.SerialPort1.ReadTimeout = 500;
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // bEnviar
            // 
            this.bEnviar.Enabled = false;
            this.bEnviar.Location = new System.Drawing.Point(236, 50);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(71, 23);
            this.bEnviar.TabIndex = 3;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // tbEnviar
            // 
            this.tbEnviar.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnviar.Location = new System.Drawing.Point(9, 50);
            this.tbEnviar.Name = "tbEnviar";
            this.tbEnviar.Size = new System.Drawing.Size(221, 21);
            this.tbEnviar.TabIndex = 2;
            this.tbEnviar.Text = "<Conecte antes de enviar>";
            // 
            // bConectar
            // 
            this.bConectar.Location = new System.Drawing.Point(216, 41);
            this.bConectar.Name = "bConectar";
            this.bConectar.Size = new System.Drawing.Size(91, 23);
            this.bConectar.TabIndex = 2;
            this.bConectar.Text = "Conectar";
            this.bConectar.UseVisualStyleBackColor = true;
            this.bConectar.Click += new System.EventHandler(this.bConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENVIAR HEXA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENVIAR ASCII";
            // 
            // cbPorta
            // 
            this.cbPorta.FormattingEnabled = true;
            this.cbPorta.Location = new System.Drawing.Point(6, 43);
            this.cbPorta.Name = "cbPorta";
            this.cbPorta.Size = new System.Drawing.Size(91, 21);
            this.cbPorta.TabIndex = 0;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(110, 43);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(91, 21);
            this.cbBaudRate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PORTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BAUD RATE";
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.cbBaudRate);
            this.gbSetup.Controls.Add(this.label4);
            this.gbSetup.Controls.Add(this.bConectar);
            this.gbSetup.Controls.Add(this.label3);
            this.gbSetup.Controls.Add(this.cbPorta);
            this.gbSetup.Location = new System.Drawing.Point(12, 12);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Size = new System.Drawing.Size(316, 76);
            this.gbSetup.TabIndex = 0;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Set-up (formato fixo 8N1)";
            // 
            // gbComunica
            // 
            this.gbComunica.Controls.Add(this.groupBox2);
            this.gbComunica.Controls.Add(this.cbAutoLimpa);
            this.gbComunica.Controls.Add(this.cbLF);
            this.gbComunica.Controls.Add(this.cbCR);
            this.gbComunica.Controls.Add(this.bEnviarH);
            this.gbComunica.Controls.Add(this.bLimpar);
            this.gbComunica.Controls.Add(this.bEnviar);
            this.gbComunica.Controls.Add(this.tbEnviarH);
            this.gbComunica.Controls.Add(this.tbEnviar);
            this.gbComunica.Controls.Add(this.label1);
            this.gbComunica.Controls.Add(this.label2);
            this.gbComunica.Location = new System.Drawing.Point(12, 94);
            this.gbComunica.Name = "gbComunica";
            this.gbComunica.Size = new System.Drawing.Size(316, 201);
            this.gbComunica.TabIndex = 1;
            this.gbComunica.TabStop = false;
            this.gbComunica.Text = "Comunicação Manual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(151, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código do Enter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mac: 0x0D \"\\r\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Linux: 0x0A \"\\n\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Windows: 0x0D 0x0A \"\\r\\n\"";
            // 
            // cbAutoLimpa
            // 
            this.cbAutoLimpa.AutoSize = true;
            this.cbAutoLimpa.Location = new System.Drawing.Point(151, 23);
            this.cbAutoLimpa.Name = "cbAutoLimpa";
            this.cbAutoLimpa.Size = new System.Drawing.Size(79, 17);
            this.cbAutoLimpa.TabIndex = 0;
            this.cbAutoLimpa.Text = "Automático";
            this.cbAutoLimpa.UseVisualStyleBackColor = true;
            // 
            // cbLF
            // 
            this.cbLF.AutoSize = true;
            this.cbLF.Location = new System.Drawing.Point(9, 169);
            this.cbLF.Name = "cbLF";
            this.cbLF.Size = new System.Drawing.Size(103, 17);
            this.cbLF.TabIndex = 7;
            this.cbLF.Text = "Line feed (0x0A)";
            this.cbLF.UseVisualStyleBackColor = true;
            // 
            // cbCR
            // 
            this.cbCR.AutoSize = true;
            this.cbCR.Location = new System.Drawing.Point(9, 146);
            this.cbCR.Name = "cbCR";
            this.cbCR.Size = new System.Drawing.Size(120, 17);
            this.cbCR.TabIndex = 6;
            this.cbCR.Text = "Carrier return (0x0D)";
            this.cbCR.UseVisualStyleBackColor = true;
            // 
            // bEnviarH
            // 
            this.bEnviarH.Enabled = false;
            this.bEnviarH.Location = new System.Drawing.Point(236, 102);
            this.bEnviarH.Name = "bEnviarH";
            this.bEnviarH.Size = new System.Drawing.Size(71, 23);
            this.bEnviarH.TabIndex = 5;
            this.bEnviarH.Text = "Enviar";
            this.bEnviarH.UseVisualStyleBackColor = true;
            this.bEnviarH.Click += new System.EventHandler(this.bEnviarH_Click);
            // 
            // bLimpar
            // 
            this.bLimpar.Location = new System.Drawing.Point(236, 19);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(71, 23);
            this.bLimpar.TabIndex = 1;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // tbEnviarH
            // 
            this.tbEnviarH.BackColor = System.Drawing.Color.DimGray;
            this.tbEnviarH.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnviarH.ForeColor = System.Drawing.Color.Yellow;
            this.tbEnviarH.Location = new System.Drawing.Point(9, 102);
            this.tbEnviarH.Name = "tbEnviarH";
            this.tbEnviarH.Size = new System.Drawing.Size(221, 21);
            this.tbEnviarH.TabIndex = 4;
            this.tbEnviarH.Text = "<Conecte antes de enviar>";
            // 
            // gbMotor
            // 
            this.gbMotor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMotor.Controls.Add(this.cbEnter);
            this.gbMotor.Controls.Add(this.cbHexaEspaço);
            this.gbMotor.Controls.Add(this.cbSom);
            this.gbMotor.Controls.Add(this.bLimpar2);
            this.gbMotor.Controls.Add(this.tbRecebidoH);
            this.gbMotor.Controls.Add(this.tbRecebido);
            this.gbMotor.Controls.Add(this.tbEnviado);
            this.gbMotor.Controls.Add(this.tbEnviadoH);
            this.gbMotor.Controls.Add(this.label14);
            this.gbMotor.Controls.Add(this.label6);
            this.gbMotor.Controls.Add(this.label13);
            this.gbMotor.Controls.Add(this.label5);
            this.gbMotor.Location = new System.Drawing.Point(339, 12);
            this.gbMotor.Name = "gbMotor";
            this.gbMotor.Size = new System.Drawing.Size(433, 537);
            this.gbMotor.TabIndex = 3;
            this.gbMotor.TabStop = false;
            this.gbMotor.Text = "Estado da porta serial";
            // 
            // cbHexaEspaço
            // 
            this.cbHexaEspaço.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHexaEspaço.AutoSize = true;
            this.cbHexaEspaço.Location = new System.Drawing.Point(228, 23);
            this.cbHexaEspaço.Name = "cbHexaEspaço";
            this.cbHexaEspaço.Size = new System.Drawing.Size(116, 17);
            this.cbHexaEspaço.TabIndex = 1;
            this.cbHexaEspaço.Text = "HEXA com espaço";
            this.toolTip1.SetToolTip(this.cbHexaEspaço, "HEXA com espaço\r\n\r\nAplica um espaço em branco entre cada um dos \r\nbytes hexadecim" +
        "ais enviados ou recebidos.");
            this.cbHexaEspaço.UseVisualStyleBackColor = true;
            // 
            // cbSom
            // 
            this.cbSom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSom.AutoSize = true;
            this.cbSom.Location = new System.Drawing.Point(175, 23);
            this.cbSom.Name = "cbSom";
            this.cbSom.Size = new System.Drawing.Size(47, 17);
            this.cbSom.TabIndex = 0;
            this.cbSom.Text = "Som";
            this.toolTip1.SetToolTip(this.cbSom, "Som\r\n\r\nDispara uma sinalização sonora a cada mensagem \r\nenviada ou recebida.");
            this.cbSom.UseVisualStyleBackColor = true;
            // 
            // bLimpar2
            // 
            this.bLimpar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLimpar2.Location = new System.Drawing.Point(350, 19);
            this.bLimpar2.Name = "bLimpar2";
            this.bLimpar2.Size = new System.Drawing.Size(75, 23);
            this.bLimpar2.TabIndex = 2;
            this.bLimpar2.Text = "Limpar";
            this.bLimpar2.UseVisualStyleBackColor = true;
            this.bLimpar2.Click += new System.EventHandler(this.bLimpar2_Click);
            // 
            // tbRecebidoH
            // 
            this.tbRecebidoH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecebidoH.BackColor = System.Drawing.Color.DimGray;
            this.tbRecebidoH.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecebidoH.ForeColor = System.Drawing.Color.Yellow;
            this.tbRecebidoH.Location = new System.Drawing.Point(6, 431);
            this.tbRecebidoH.Multiline = true;
            this.tbRecebidoH.Name = "tbRecebidoH";
            this.tbRecebidoH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecebidoH.Size = new System.Drawing.Size(419, 100);
            this.tbRecebidoH.TabIndex = 6;
            // 
            // tbRecebido
            // 
            this.tbRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecebido.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecebido.Location = new System.Drawing.Point(6, 312);
            this.tbRecebido.Multiline = true;
            this.tbRecebido.Name = "tbRecebido";
            this.tbRecebido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecebido.Size = new System.Drawing.Size(419, 100);
            this.tbRecebido.TabIndex = 5;
            // 
            // tbEnviado
            // 
            this.tbEnviado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnviado.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnviado.Location = new System.Drawing.Point(6, 52);
            this.tbEnviado.Multiline = true;
            this.tbEnviado.Name = "tbEnviado";
            this.tbEnviado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEnviado.Size = new System.Drawing.Size(419, 100);
            this.tbEnviado.TabIndex = 3;
            // 
            // tbEnviadoH
            // 
            this.tbEnviadoH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnviadoH.BackColor = System.Drawing.Color.DimGray;
            this.tbEnviadoH.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnviadoH.ForeColor = System.Drawing.Color.Yellow;
            this.tbEnviadoH.Location = new System.Drawing.Point(6, 168);
            this.tbEnviadoH.Multiline = true;
            this.tbEnviadoH.Name = "tbEnviadoH";
            this.tbEnviadoH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEnviadoH.Size = new System.Drawing.Size(419, 100);
            this.tbEnviadoH.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "RECEBIDO HEXA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "RECEBIDO ASCII";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "ENVIADO HEXA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ENVIADO ASCII";
            // 
            // bT3
            // 
            this.bT3.BackColor = System.Drawing.Color.LightCoral;
            this.bT3.Enabled = false;
            this.bT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bT3.Location = new System.Drawing.Point(8, 132);
            this.bT3.Name = "bT3";
            this.bT3.Size = new System.Drawing.Size(115, 47);
            this.bT3.TabIndex = 4;
            this.bT3.Text = "Mens. 3";
            this.bT3.UseVisualStyleBackColor = false;
            this.bT3.Click += new System.EventHandler(this.bT3_Click);
            // 
            // bT4
            // 
            this.bT4.BackColor = System.Drawing.Color.Magenta;
            this.bT4.Enabled = false;
            this.bT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bT4.Location = new System.Drawing.Point(8, 185);
            this.bT4.Name = "bT4";
            this.bT4.Size = new System.Drawing.Size(115, 47);
            this.bT4.TabIndex = 6;
            this.bT4.Text = "Mens. 4";
            this.bT4.UseVisualStyleBackColor = false;
            this.bT4.Click += new System.EventHandler(this.bT4_Click);
            // 
            // bT1
            // 
            this.bT1.BackColor = System.Drawing.Color.Aqua;
            this.bT1.Enabled = false;
            this.bT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bT1.Location = new System.Drawing.Point(8, 26);
            this.bT1.Name = "bT1";
            this.bT1.Size = new System.Drawing.Size(115, 47);
            this.bT1.TabIndex = 0;
            this.bT1.Text = "Mens. 1";
            this.bT1.UseVisualStyleBackColor = false;
            this.bT1.Click += new System.EventHandler(this.bT1_Click);
            // 
            // bT2
            // 
            this.bT2.BackColor = System.Drawing.Color.Lime;
            this.bT2.Enabled = false;
            this.bT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bT2.Location = new System.Drawing.Point(8, 79);
            this.bT2.Name = "bT2";
            this.bT2.Size = new System.Drawing.Size(115, 47);
            this.bT2.TabIndex = 2;
            this.bT2.Text = "Mens. 2";
            this.bT2.UseVisualStyleBackColor = false;
            this.bT2.Click += new System.EventHandler(this.bT2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbT4);
            this.groupBox1.Controls.Add(this.tbT3);
            this.groupBox1.Controls.Add(this.tbT2);
            this.groupBox1.Controls.Add(this.tbT1);
            this.groupBox1.Controls.Add(this.bT1);
            this.groupBox1.Controls.Add(this.bT2);
            this.groupBox1.Controls.Add(this.bT4);
            this.groupBox1.Controls.Add(this.bT3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(13, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunicação Automática";
            // 
            // tbT4
            // 
            this.tbT4.BackColor = System.Drawing.Color.Magenta;
            this.tbT4.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbT4.Location = new System.Drawing.Point(129, 201);
            this.tbT4.Name = "tbT4";
            this.tbT4.Size = new System.Drawing.Size(180, 21);
            this.tbT4.TabIndex = 7;
            this.tbT4.Text = "<Conecte antes de enviar>";
            // 
            // tbT3
            // 
            this.tbT3.BackColor = System.Drawing.Color.LightCoral;
            this.tbT3.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbT3.Location = new System.Drawing.Point(129, 148);
            this.tbT3.Name = "tbT3";
            this.tbT3.Size = new System.Drawing.Size(180, 21);
            this.tbT3.TabIndex = 5;
            this.tbT3.Text = "<Conecte antes de enviar>";
            // 
            // tbT2
            // 
            this.tbT2.BackColor = System.Drawing.Color.Lime;
            this.tbT2.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbT2.Location = new System.Drawing.Point(129, 95);
            this.tbT2.Name = "tbT2";
            this.tbT2.Size = new System.Drawing.Size(180, 21);
            this.tbT2.TabIndex = 3;
            this.tbT2.Text = "<Conecte antes de enviar>";
            // 
            // tbT1
            // 
            this.tbT1.BackColor = System.Drawing.Color.Aqua;
            this.tbT1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbT1.Location = new System.Drawing.Point(129, 42);
            this.tbT1.Name = "tbT1";
            this.tbT1.Size = new System.Drawing.Size(180, 21);
            this.tbT1.TabIndex = 1;
            this.tbT1.Text = "<Conecte antes de enviar>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "ENVIAR ASCII";
            // 
            // cbEnter
            // 
            this.cbEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnter.AutoSize = true;
            this.cbEnter.Location = new System.Drawing.Point(118, 23);
            this.cbEnter.Name = "cbEnter";
            this.cbEnter.Size = new System.Drawing.Size(51, 17);
            this.cbEnter.TabIndex = 7;
            this.cbEnter.Text = "Enter";
            this.toolTip1.SetToolTip(this.cbEnter, "Enter\r\n\r\nInsere uma quebra de linha sempre que um \r\ncódigo 0x0D ou 0x0A for envia" +
        "do ou recebido.\r\nObs.: 0x0D seguindo de 0x0A sempre geram uma\r\nquebra de linha n" +
        "o formato ASCII.");
            this.cbEnter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMotor);
            this.Controls.Add(this.gbComunica);
            this.Controls.Add(this.gbSetup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal Serial ASCII HEXA (prof.  Leandro)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.gbComunica.ResumeLayout(false);
            this.gbComunica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbMotor.ResumeLayout(false);
            this.gbMotor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.TextBox tbEnviar;
        private System.Windows.Forms.Button bConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPorta;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.GroupBox gbComunica;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.GroupBox gbMotor;
        private System.Windows.Forms.TextBox tbEnviado;
        private System.Windows.Forms.TextBox tbEnviadoH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bT3;
        private System.Windows.Forms.Button bT4;
        private System.Windows.Forms.Button bT1;
        private System.Windows.Forms.Button bT2;
        private System.Windows.Forms.Button bLimpar2;
        private System.Windows.Forms.TextBox tbRecebidoH;
        private System.Windows.Forms.TextBox tbRecebido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbSom;
        private System.Windows.Forms.Button bEnviarH;
        private System.Windows.Forms.TextBox tbEnviarH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLF;
        private System.Windows.Forms.CheckBox cbCR;
        private System.Windows.Forms.CheckBox cbAutoLimpa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbHexaEspaço;
        private System.Windows.Forms.TextBox tbT4;
        private System.Windows.Forms.TextBox tbT3;
        private System.Windows.Forms.TextBox tbT2;
        private System.Windows.Forms.TextBox tbT1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbEnter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


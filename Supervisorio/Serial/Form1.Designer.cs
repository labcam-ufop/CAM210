namespace Serial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.labelSelecPorta = new System.Windows.Forms.Label();
            this.groupBoxComSerial = new System.Windows.Forms.GroupBox();
            this.labelSaidaDados = new System.Windows.Forms.Label();
            this.labelEntradaDados = new System.Windows.Forms.Label();
            this.labelMed6 = new System.Windows.Forms.Label();
            this.labelMed5 = new System.Windows.Forms.Label();
            this.labelMed1 = new System.Windows.Forms.Label();
            this.labelMed4 = new System.Windows.Forms.Label();
            this.labelMed2 = new System.Windows.Forms.Label();
            this.labelMed3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArquivotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjudaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGauge1 = new AGauge.AGauge();
            this.aGauge2 = new AGauge.AGauge();
            this.labelTempAmb = new System.Windows.Forms.Label();
            this.labelTempSolo = new System.Windows.Forms.Label();
            this.groupBoxMedicoes = new System.Windows.Forms.GroupBox();
            this.labelMed7 = new System.Windows.Forms.Label();
            this.MedicoesTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxTemperaturas = new System.Windows.Forms.GroupBox();
            this.GroupBoxGraficos = new System.Windows.Forms.GroupBox();
            this.aChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageComunic = new System.Windows.Forms.TabPage();
            this.btTeste = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLiga = new System.Windows.Forms.Button();
            this.btdesliga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageMed = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSensor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerChart1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxComSerial.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMedicoes.SuspendLayout();
            this.groupBoxTemperaturas.SuspendLayout();
            this.GroupBoxGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aChart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageComunic.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageMed.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(6, 72);
            this.textBoxEntrada.Multiline = true;
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(619, 195);
            this.textBoxEntrada.TabIndex = 1;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Location = new System.Drawing.Point(7, 296);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(344, 34);
            this.textBoxSaida.TabIndex = 2;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(558, 268);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(67, 23);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(357, 307);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(202, 24);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 8;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // labelSelecPorta
            // 
            this.labelSelecPorta.AutoSize = true;
            this.labelSelecPorta.Location = new System.Drawing.Point(8, 28);
            this.labelSelecPorta.Name = "labelSelecPorta";
            this.labelSelecPorta.Size = new System.Drawing.Size(93, 13);
            this.labelSelecPorta.TabIndex = 10;
            this.labelSelecPorta.Text = "Selecione a porta:";
            // 
            // groupBoxComSerial
            // 
            this.groupBoxComSerial.Controls.Add(this.labelSaidaDados);
            this.groupBoxComSerial.Controls.Add(this.labelEntradaDados);
            this.groupBoxComSerial.Controls.Add(this.labelSelecPorta);
            this.groupBoxComSerial.Controls.Add(this.comboBox1);
            this.groupBoxComSerial.Controls.Add(this.buttonAtualizar);
            this.groupBoxComSerial.Controls.Add(this.textBoxEntrada);
            this.groupBoxComSerial.Controls.Add(this.buttonLimpar);
            this.groupBoxComSerial.Controls.Add(this.textBoxSaida);
            this.groupBoxComSerial.Controls.Add(this.buttonEnviar);
            this.groupBoxComSerial.Location = new System.Drawing.Point(8, 6);
            this.groupBoxComSerial.Name = "groupBoxComSerial";
            this.groupBoxComSerial.Size = new System.Drawing.Size(631, 341);
            this.groupBoxComSerial.TabIndex = 11;
            this.groupBoxComSerial.TabStop = false;
            this.groupBoxComSerial.Text = "Comunicação Serial";
            // 
            // labelSaidaDados
            // 
            this.labelSaidaDados.AutoSize = true;
            this.labelSaidaDados.Location = new System.Drawing.Point(6, 277);
            this.labelSaidaDados.Name = "labelSaidaDados";
            this.labelSaidaDados.Size = new System.Drawing.Size(88, 13);
            this.labelSaidaDados.TabIndex = 12;
            this.labelSaidaDados.Text = "Saída de Dados:";
            // 
            // labelEntradaDados
            // 
            this.labelEntradaDados.AutoSize = true;
            this.labelEntradaDados.Location = new System.Drawing.Point(6, 56);
            this.labelEntradaDados.Name = "labelEntradaDados";
            this.labelEntradaDados.Size = new System.Drawing.Size(96, 13);
            this.labelEntradaDados.TabIndex = 11;
            this.labelEntradaDados.Text = "Entrada de Dados:";
            // 
            // labelMed6
            // 
            this.labelMed6.AutoSize = true;
            this.labelMed6.Location = new System.Drawing.Point(162, 160);
            this.labelMed6.MaximumSize = new System.Drawing.Size(40, 13);
            this.labelMed6.Name = "labelMed6";
            this.labelMed6.Size = new System.Drawing.Size(13, 13);
            this.labelMed6.TabIndex = 29;
            this.labelMed6.Text = "0";
            // 
            // labelMed5
            // 
            this.labelMed5.AutoSize = true;
            this.labelMed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed5.Location = new System.Drawing.Point(162, 134);
            this.labelMed5.MaximumSize = new System.Drawing.Size(32, 20);
            this.labelMed5.Name = "labelMed5";
            this.labelMed5.Size = new System.Drawing.Size(13, 13);
            this.labelMed5.TabIndex = 22;
            this.labelMed5.Text = "0";
            // 
            // labelMed1
            // 
            this.labelMed1.AutoSize = true;
            this.labelMed1.Location = new System.Drawing.Point(162, 30);
            this.labelMed1.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed1.Name = "labelMed1";
            this.labelMed1.Size = new System.Drawing.Size(13, 13);
            this.labelMed1.TabIndex = 18;
            this.labelMed1.Text = "0";
            // 
            // labelMed4
            // 
            this.labelMed4.AutoSize = true;
            this.labelMed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed4.Location = new System.Drawing.Point(162, 108);
            this.labelMed4.MaximumSize = new System.Drawing.Size(32, 20);
            this.labelMed4.Name = "labelMed4";
            this.labelMed4.Size = new System.Drawing.Size(13, 13);
            this.labelMed4.TabIndex = 21;
            this.labelMed4.Text = "0";
            // 
            // labelMed2
            // 
            this.labelMed2.AutoSize = true;
            this.labelMed2.Location = new System.Drawing.Point(162, 56);
            this.labelMed2.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed2.Name = "labelMed2";
            this.labelMed2.Size = new System.Drawing.Size(13, 13);
            this.labelMed2.TabIndex = 19;
            this.labelMed2.Text = "0";
            // 
            // labelMed3
            // 
            this.labelMed3.AutoSize = true;
            this.labelMed3.Location = new System.Drawing.Point(162, 82);
            this.labelMed3.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed3.Name = "labelMed3";
            this.labelMed3.Size = new System.Drawing.Size(13, 13);
            this.labelMed3.TabIndex = 20;
            this.labelMed3.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(198, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Unidade";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivotoolStripMenuItem,
            this.AjudaStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArquivotoolStripMenuItem
            // 
            this.ArquivotoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ArquivotoolStripMenuItem.Name = "ArquivotoolStripMenuItem";
            this.ArquivotoolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ArquivotoolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // AjudaStripMenuItem
            // 
            this.AjudaStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.AjudaStripMenuItem.Name = "AjudaStripMenuItem";
            this.AjudaStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.AjudaStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.Window;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge1.Location = new System.Drawing.Point(19, 21);
            this.aGauge1.MaxValue = 50F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Red;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.Red;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 50F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        35F,
        50F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        35F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 35F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(207, 113);
            this.aGauge1.TabIndex = 14;
            this.aGauge1.Text = "\\";
            this.aGauge1.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.SystemColors.Window;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 180;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            this.aGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge2.Location = new System.Drawing.Point(19, 156);
            this.aGauge2.MaxValue = 50F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Red;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.Color.Red;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 50F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        35F,
        50F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        35F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 35F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(207, 113);
            this.aGauge2.TabIndex = 15;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // labelTempAmb
            // 
            this.labelTempAmb.AutoSize = true;
            this.labelTempAmb.Location = new System.Drawing.Point(82, 272);
            this.labelTempAmb.Name = "labelTempAmb";
            this.labelTempAmb.Size = new System.Drawing.Size(62, 13);
            this.labelTempAmb.TabIndex = 16;
            this.labelTempAmb.Text = "Grandeza 2";
            // 
            // labelTempSolo
            // 
            this.labelTempSolo.AutoSize = true;
            this.labelTempSolo.Location = new System.Drawing.Point(82, 128);
            this.labelTempSolo.Name = "labelTempSolo";
            this.labelTempSolo.Size = new System.Drawing.Size(62, 13);
            this.labelTempSolo.TabIndex = 17;
            this.labelTempSolo.Text = "Grandeza 1";
            // 
            // groupBoxMedicoes
            // 
            this.groupBoxMedicoes.Controls.Add(this.labelMed7);
            this.groupBoxMedicoes.Controls.Add(this.MedicoesTextBox);
            this.groupBoxMedicoes.Controls.Add(this.labelMed6);
            this.groupBoxMedicoes.Controls.Add(this.labelMed1);
            this.groupBoxMedicoes.Controls.Add(this.labelMed5);
            this.groupBoxMedicoes.Controls.Add(this.label18);
            this.groupBoxMedicoes.Controls.Add(this.labelMed2);
            this.groupBoxMedicoes.Controls.Add(this.labelMed4);
            this.groupBoxMedicoes.Controls.Add(this.labelMed3);
            this.groupBoxMedicoes.Location = new System.Drawing.Point(729, 6);
            this.groupBoxMedicoes.Name = "groupBoxMedicoes";
            this.groupBoxMedicoes.Size = new System.Drawing.Size(261, 304);
            this.groupBoxMedicoes.TabIndex = 56;
            this.groupBoxMedicoes.TabStop = false;
            this.groupBoxMedicoes.Text = "Medições";
            // 
            // labelMed7
            // 
            this.labelMed7.AutoSize = true;
            this.labelMed7.Location = new System.Drawing.Point(162, 186);
            this.labelMed7.MaximumSize = new System.Drawing.Size(40, 13);
            this.labelMed7.Name = "labelMed7";
            this.labelMed7.Size = new System.Drawing.Size(13, 13);
            this.labelMed7.TabIndex = 35;
            this.labelMed7.Text = "0";
            // 
            // MedicoesTextBox
            // 
            this.MedicoesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MedicoesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicoesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MedicoesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicoesTextBox.Location = new System.Drawing.Point(6, 30);
            this.MedicoesTextBox.Name = "MedicoesTextBox";
            this.MedicoesTextBox.ReadOnly = true;
            this.MedicoesTextBox.Size = new System.Drawing.Size(138, 187);
            this.MedicoesTextBox.TabIndex = 22;
            this.MedicoesTextBox.Text = "Medição 1:\n\nMedição 2:\n\nMedição 3:\n\nMedição 4:\n\nMedição 5:\n\nMedição 6:\n\nMedição 7" +
    ":";
            // 
            // groupBoxTemperaturas
            // 
            this.groupBoxTemperaturas.Controls.Add(this.labelTempSolo);
            this.groupBoxTemperaturas.Controls.Add(this.aGauge1);
            this.groupBoxTemperaturas.Controls.Add(this.aGauge2);
            this.groupBoxTemperaturas.Controls.Add(this.labelTempAmb);
            this.groupBoxTemperaturas.Location = new System.Drawing.Point(729, 316);
            this.groupBoxTemperaturas.Name = "groupBoxTemperaturas";
            this.groupBoxTemperaturas.Size = new System.Drawing.Size(261, 318);
            this.groupBoxTemperaturas.TabIndex = 58;
            this.groupBoxTemperaturas.TabStop = false;
            this.groupBoxTemperaturas.Text = "Indicações";
            // 
            // GroupBoxGraficos
            // 
            this.GroupBoxGraficos.Controls.Add(this.aChart2);
            this.GroupBoxGraficos.Controls.Add(this.aChart1);
            this.GroupBoxGraficos.Location = new System.Drawing.Point(3, 6);
            this.GroupBoxGraficos.Name = "GroupBoxGraficos";
            this.GroupBoxGraficos.Size = new System.Drawing.Size(720, 628);
            this.GroupBoxGraficos.TabIndex = 59;
            this.GroupBoxGraficos.TabStop = false;
            this.GroupBoxGraficos.Text = "Gráficos";
            // 
            // aChart2
            // 
            chartArea1.Name = "ChartArea1";
            this.aChart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.aChart2.Legends.Add(legend1);
            this.aChart2.Location = new System.Drawing.Point(6, 297);
            this.aChart2.Name = "aChart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura Filtrada";
            this.aChart2.Series.Add(series1);
            this.aChart2.Size = new System.Drawing.Size(708, 284);
            this.aChart2.TabIndex = 22;
            this.aChart2.Text = "chart1";
            // 
            // aChart1
            // 
            chartArea2.Name = "ChartArea1";
            this.aChart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.aChart1.Legends.Add(legend2);
            this.aChart1.Location = new System.Drawing.Point(6, 19);
            this.aChart1.Name = "aChart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            this.aChart1.Series.Add(series2);
            this.aChart1.Size = new System.Drawing.Size(708, 284);
            this.aChart1.TabIndex = 21;
            this.aChart1.Text = "aChart";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageComunic);
            this.tabControl1.Controls.Add(this.tabPageMed);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 665);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPageComunic
            // 
            this.tabPageComunic.Controls.Add(this.btTeste);
            this.tabPageComunic.Controls.Add(this.groupBox2);
            this.tabPageComunic.Controls.Add(this.groupBox1);
            this.tabPageComunic.Controls.Add(this.groupBoxComSerial);
            this.tabPageComunic.Location = new System.Drawing.Point(4, 22);
            this.tabPageComunic.Name = "tabPageComunic";
            this.tabPageComunic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComunic.Size = new System.Drawing.Size(998, 639);
            this.tabPageComunic.TabIndex = 0;
            this.tabPageComunic.Text = "Comunicação";
            this.tabPageComunic.UseVisualStyleBackColor = true;
            // 
            // btTeste
            // 
            this.btTeste.Location = new System.Drawing.Point(662, 216);
            this.btTeste.Margin = new System.Windows.Forms.Padding(2);
            this.btTeste.Name = "btTeste";
            this.btTeste.Size = new System.Drawing.Size(114, 56);
            this.btTeste.TabIndex = 65;
            this.btTeste.Text = "Teste";
            this.btTeste.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLiga);
            this.groupBox2.Controls.Add(this.btdesliga);
            this.groupBox2.Location = new System.Drawing.Point(645, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(200, 81);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heater";
            // 
            // btLiga
            // 
            this.btLiga.Location = new System.Drawing.Point(4, 17);
            this.btLiga.Margin = new System.Windows.Forms.Padding(2);
            this.btLiga.Name = "btLiga";
            this.btLiga.Size = new System.Drawing.Size(56, 36);
            this.btLiga.TabIndex = 62;
            this.btLiga.Text = "Liga";
            this.btLiga.UseVisualStyleBackColor = true;
            this.btLiga.Click += new System.EventHandler(this.btLiga_Click);
            // 
            // btdesliga
            // 
            this.btdesliga.Location = new System.Drawing.Point(74, 17);
            this.btdesliga.Margin = new System.Windows.Forms.Padding(2);
            this.btdesliga.Name = "btdesliga";
            this.btdesliga.Size = new System.Drawing.Size(56, 36);
            this.btdesliga.TabIndex = 63;
            this.btdesliga.Text = "desliga";
            this.btdesliga.UseVisualStyleBackColor = true;
            this.btdesliga.Click += new System.EventHandler(this.btdesliga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(645, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplo de Recepção de Dados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Dado 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Dado 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Dado 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "0000";
            // 
            // tabPageMed
            // 
            this.tabPageMed.Controls.Add(this.groupBoxTemperaturas);
            this.tabPageMed.Controls.Add(this.GroupBoxGraficos);
            this.tabPageMed.Controls.Add(this.groupBoxMedicoes);
            this.tabPageMed.Location = new System.Drawing.Point(4, 22);
            this.tabPageMed.Name = "tabPageMed";
            this.tabPageMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMed.Size = new System.Drawing.Size(998, 639);
            this.tabPageMed.TabIndex = 1;
            this.tabPageMed.Text = "Medições";
            this.tabPageMed.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSensor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 639);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Sensores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSensor
            // 
            this.dataGridViewSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewSensor.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSensor.Name = "dataGridViewSensor";
            this.dataGridViewSensor.RowHeadersWidth = 62;
            this.dataGridViewSensor.Size = new System.Drawing.Size(952, 626);
            this.dataGridViewSensor.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medição 1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medição 2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Medição 3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Medição 4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Medição 5";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Medição 6";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Medição 7";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Medição 8";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Medição 9";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // timerChart1
            // 
            this.timerChart1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(771, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Supervisório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxComSerial.ResumeLayout(false);
            this.groupBoxComSerial.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMedicoes.ResumeLayout(false);
            this.groupBoxMedicoes.PerformLayout();
            this.groupBoxTemperaturas.ResumeLayout(false);
            this.groupBoxTemperaturas.PerformLayout();
            this.GroupBoxGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aChart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageComunic.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageMed.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonEnviar;
        //private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonAtualizar;
        //private DadosSensoresDataSet dadosSensoresDataSet1;
        private System.Windows.Forms.Label labelSelecPorta;
        private System.Windows.Forms.GroupBox groupBoxComSerial;
        private System.Windows.Forms.Label labelSaidaDados;
        private System.Windows.Forms.Label labelEntradaDados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArquivotoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjudaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label labelMed5;
        private System.Windows.Forms.Label labelMed4;
        private System.Windows.Forms.Label labelMed3;
        private System.Windows.Forms.Label labelMed2;
        private System.Windows.Forms.Label labelMed1;
        private System.Windows.Forms.Label labelMed6;
        private System.Windows.Forms.Label label18;
        private AGauge.AGauge aGauge1;
        private AGauge.AGauge aGauge2;
        private System.Windows.Forms.Label labelTempAmb;
        private System.Windows.Forms.Label labelTempSolo;
        private System.Windows.Forms.GroupBox groupBoxMedicoes;
        private System.Windows.Forms.GroupBox groupBoxTemperaturas;
        private System.Windows.Forms.GroupBox GroupBoxGraficos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageComunic;
        private System.Windows.Forms.TabPage tabPageMed;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMed7;
        private System.Windows.Forms.RichTextBox MedicoesTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart aChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart aChart2;
        private System.Windows.Forms.Timer timerChart1;
        private System.Windows.Forms.Button btLiga;
        private System.Windows.Forms.Button btdesliga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTeste;
    }
}


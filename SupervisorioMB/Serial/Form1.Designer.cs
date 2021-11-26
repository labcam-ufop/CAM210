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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.comboBox1.Location = new System.Drawing.Point(142, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(8, 89);
            this.textBoxEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEntrada.Multiline = true;
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(824, 239);
            this.textBoxEntrada.TabIndex = 1;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Location = new System.Drawing.Point(9, 364);
            this.textBoxSaida.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(457, 41);
            this.textBoxSaida.TabIndex = 2;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(744, 330);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(89, 28);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(476, 378);
            this.buttonEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(100, 28);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(269, 30);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(100, 28);
            this.buttonAtualizar.TabIndex = 8;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // labelSelecPorta
            // 
            this.labelSelecPorta.AutoSize = true;
            this.labelSelecPorta.Location = new System.Drawing.Point(11, 34);
            this.labelSelecPorta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelecPorta.Name = "labelSelecPorta";
            this.labelSelecPorta.Size = new System.Drawing.Size(123, 17);
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
            this.groupBoxComSerial.Location = new System.Drawing.Point(11, 7);
            this.groupBoxComSerial.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxComSerial.Name = "groupBoxComSerial";
            this.groupBoxComSerial.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxComSerial.Size = new System.Drawing.Size(841, 420);
            this.groupBoxComSerial.TabIndex = 11;
            this.groupBoxComSerial.TabStop = false;
            this.groupBoxComSerial.Text = "Comunicação Serial";
            // 
            // labelSaidaDados
            // 
            this.labelSaidaDados.AutoSize = true;
            this.labelSaidaDados.Location = new System.Drawing.Point(8, 341);
            this.labelSaidaDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaidaDados.Name = "labelSaidaDados";
            this.labelSaidaDados.Size = new System.Drawing.Size(113, 17);
            this.labelSaidaDados.TabIndex = 12;
            this.labelSaidaDados.Text = "Saída de Dados:";
            // 
            // labelEntradaDados
            // 
            this.labelEntradaDados.AutoSize = true;
            this.labelEntradaDados.Location = new System.Drawing.Point(8, 69);
            this.labelEntradaDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEntradaDados.Name = "labelEntradaDados";
            this.labelEntradaDados.Size = new System.Drawing.Size(127, 17);
            this.labelEntradaDados.TabIndex = 11;
            this.labelEntradaDados.Text = "Entrada de Dados:";
            // 
            // labelMed6
            // 
            this.labelMed6.AutoSize = true;
            this.labelMed6.Location = new System.Drawing.Point(216, 197);
            this.labelMed6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed6.MaximumSize = new System.Drawing.Size(53, 16);
            this.labelMed6.Name = "labelMed6";
            this.labelMed6.Size = new System.Drawing.Size(16, 16);
            this.labelMed6.TabIndex = 29;
            this.labelMed6.Text = "0";
            // 
            // labelMed5
            // 
            this.labelMed5.AutoSize = true;
            this.labelMed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed5.Location = new System.Drawing.Point(216, 165);
            this.labelMed5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed5.MaximumSize = new System.Drawing.Size(43, 25);
            this.labelMed5.Name = "labelMed5";
            this.labelMed5.Size = new System.Drawing.Size(16, 17);
            this.labelMed5.TabIndex = 22;
            this.labelMed5.Text = "0";
            // 
            // labelMed1
            // 
            this.labelMed1.AutoSize = true;
            this.labelMed1.Location = new System.Drawing.Point(216, 37);
            this.labelMed1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed1.MaximumSize = new System.Drawing.Size(37, 16);
            this.labelMed1.Name = "labelMed1";
            this.labelMed1.Size = new System.Drawing.Size(16, 16);
            this.labelMed1.TabIndex = 18;
            this.labelMed1.Text = "0";
            // 
            // labelMed4
            // 
            this.labelMed4.AutoSize = true;
            this.labelMed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed4.Location = new System.Drawing.Point(216, 133);
            this.labelMed4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed4.MaximumSize = new System.Drawing.Size(43, 25);
            this.labelMed4.Name = "labelMed4";
            this.labelMed4.Size = new System.Drawing.Size(16, 17);
            this.labelMed4.TabIndex = 21;
            this.labelMed4.Text = "0";
            // 
            // labelMed2
            // 
            this.labelMed2.AutoSize = true;
            this.labelMed2.Location = new System.Drawing.Point(216, 69);
            this.labelMed2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed2.MaximumSize = new System.Drawing.Size(37, 16);
            this.labelMed2.Name = "labelMed2";
            this.labelMed2.Size = new System.Drawing.Size(16, 16);
            this.labelMed2.TabIndex = 19;
            this.labelMed2.Text = "0";
            // 
            // labelMed3
            // 
            this.labelMed3.AutoSize = true;
            this.labelMed3.Location = new System.Drawing.Point(216, 101);
            this.labelMed3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed3.MaximumSize = new System.Drawing.Size(37, 16);
            this.labelMed3.Name = "labelMed3";
            this.labelMed3.Size = new System.Drawing.Size(16, 16);
            this.labelMed3.TabIndex = 20;
            this.labelMed3.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(264, 37);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArquivotoolStripMenuItem
            // 
            this.ArquivotoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ArquivotoolStripMenuItem.Name = "ArquivotoolStripMenuItem";
            this.ArquivotoolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ArquivotoolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // AjudaStripMenuItem
            // 
            this.AjudaStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.AjudaStripMenuItem.Name = "AjudaStripMenuItem";
            this.AjudaStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.AjudaStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
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
            this.aGauge1.Location = new System.Drawing.Point(25, 26);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(4);
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
            this.aGauge1.Size = new System.Drawing.Size(276, 139);
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
            this.aGauge2.Location = new System.Drawing.Point(25, 192);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(4);
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
            this.aGauge2.Size = new System.Drawing.Size(276, 139);
            this.aGauge2.TabIndex = 15;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // labelTempAmb
            // 
            this.labelTempAmb.AutoSize = true;
            this.labelTempAmb.Location = new System.Drawing.Point(109, 335);
            this.labelTempAmb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempAmb.Name = "labelTempAmb";
            this.labelTempAmb.Size = new System.Drawing.Size(83, 17);
            this.labelTempAmb.TabIndex = 16;
            this.labelTempAmb.Text = "Grandeza 2";
            // 
            // labelTempSolo
            // 
            this.labelTempSolo.AutoSize = true;
            this.labelTempSolo.Location = new System.Drawing.Point(109, 157);
            this.labelTempSolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempSolo.Name = "labelTempSolo";
            this.labelTempSolo.Size = new System.Drawing.Size(83, 17);
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
            this.groupBoxMedicoes.Location = new System.Drawing.Point(972, 7);
            this.groupBoxMedicoes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMedicoes.Name = "groupBoxMedicoes";
            this.groupBoxMedicoes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMedicoes.Size = new System.Drawing.Size(348, 374);
            this.groupBoxMedicoes.TabIndex = 56;
            this.groupBoxMedicoes.TabStop = false;
            this.groupBoxMedicoes.Text = "Medições";
            // 
            // labelMed7
            // 
            this.labelMed7.AutoSize = true;
            this.labelMed7.Location = new System.Drawing.Point(216, 229);
            this.labelMed7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed7.MaximumSize = new System.Drawing.Size(53, 16);
            this.labelMed7.Name = "labelMed7";
            this.labelMed7.Size = new System.Drawing.Size(16, 16);
            this.labelMed7.TabIndex = 35;
            this.labelMed7.Text = "0";
            // 
            // MedicoesTextBox
            // 
            this.MedicoesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MedicoesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicoesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MedicoesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicoesTextBox.Location = new System.Drawing.Point(8, 37);
            this.MedicoesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicoesTextBox.Name = "MedicoesTextBox";
            this.MedicoesTextBox.ReadOnly = true;
            this.MedicoesTextBox.Size = new System.Drawing.Size(184, 230);
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
            this.groupBoxTemperaturas.Location = new System.Drawing.Point(972, 389);
            this.groupBoxTemperaturas.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTemperaturas.Name = "groupBoxTemperaturas";
            this.groupBoxTemperaturas.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTemperaturas.Size = new System.Drawing.Size(348, 391);
            this.groupBoxTemperaturas.TabIndex = 58;
            this.groupBoxTemperaturas.TabStop = false;
            this.groupBoxTemperaturas.Text = "Indicações";
            // 
            // GroupBoxGraficos
            // 
            this.GroupBoxGraficos.Controls.Add(this.aChart2);
            this.GroupBoxGraficos.Controls.Add(this.aChart1);
            this.GroupBoxGraficos.Location = new System.Drawing.Point(4, 7);
            this.GroupBoxGraficos.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxGraficos.Name = "GroupBoxGraficos";
            this.GroupBoxGraficos.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxGraficos.Size = new System.Drawing.Size(960, 773);
            this.GroupBoxGraficos.TabIndex = 59;
            this.GroupBoxGraficos.TabStop = false;
            this.GroupBoxGraficos.Text = "Gráficos";
            // 
            // aChart2
            // 
            chartArea3.Name = "ChartArea1";
            this.aChart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.aChart2.Legends.Add(legend3);
            this.aChart2.Location = new System.Drawing.Point(8, 366);
            this.aChart2.Margin = new System.Windows.Forms.Padding(4);
            this.aChart2.Name = "aChart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Temperatura Filtrada";
            this.aChart2.Series.Add(series3);
            this.aChart2.Size = new System.Drawing.Size(944, 350);
            this.aChart2.TabIndex = 22;
            this.aChart2.Text = "chart1";
            // 
            // aChart1
            // 
            chartArea4.Name = "ChartArea1";
            this.aChart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.aChart1.Legends.Add(legend4);
            this.aChart1.Location = new System.Drawing.Point(8, 23);
            this.aChart1.Margin = new System.Windows.Forms.Padding(4);
            this.aChart1.Name = "aChart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Legend = "Legend1";
            series4.Name = "Temperatura";
            this.aChart1.Series.Add(series4);
            this.aChart1.Size = new System.Drawing.Size(944, 350);
            this.aChart1.TabIndex = 21;
            this.aChart1.Text = "aChart";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageComunic);
            this.tabControl1.Controls.Add(this.tabPageMed);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 818);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPageComunic
            // 
            this.tabPageComunic.Controls.Add(this.groupBox2);
            this.tabPageComunic.Controls.Add(this.groupBox1);
            this.tabPageComunic.Controls.Add(this.groupBoxComSerial);
            this.tabPageComunic.Location = new System.Drawing.Point(4, 25);
            this.tabPageComunic.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageComunic.Name = "tabPageComunic";
            this.tabPageComunic.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageComunic.Size = new System.Drawing.Size(1333, 789);
            this.tabPageComunic.TabIndex = 0;
            this.tabPageComunic.Text = "Comunicação";
            this.tabPageComunic.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLiga);
            this.groupBox2.Controls.Add(this.btdesliga);
            this.groupBox2.Location = new System.Drawing.Point(860, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 100);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heater";
            // 
            // btLiga
            // 
            this.btLiga.Location = new System.Drawing.Point(6, 21);
            this.btLiga.Name = "btLiga";
            this.btLiga.Size = new System.Drawing.Size(75, 44);
            this.btLiga.TabIndex = 62;
            this.btLiga.Text = "Liga";
            this.btLiga.UseVisualStyleBackColor = true;
            this.btLiga.Click += new System.EventHandler(this.btLiga_Click);
            // 
            // btdesliga
            // 
            this.btdesliga.Location = new System.Drawing.Point(99, 21);
            this.btdesliga.Name = "btdesliga";
            this.btdesliga.Size = new System.Drawing.Size(75, 44);
            this.btdesliga.TabIndex = 63;
            this.btdesliga.Text = "desliga";
            this.btdesliga.UseVisualStyleBackColor = true;
            this.btdesliga.Click += new System.EventHandler(this.btdesliga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(860, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 153);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplo de Recepção de Dados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Dado 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Dado 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Dado 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "0000";
            // 
            // tabPageMed
            // 
            this.tabPageMed.Controls.Add(this.groupBoxTemperaturas);
            this.tabPageMed.Controls.Add(this.GroupBoxGraficos);
            this.tabPageMed.Controls.Add(this.groupBoxMedicoes);
            this.tabPageMed.Location = new System.Drawing.Point(4, 25);
            this.tabPageMed.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMed.Name = "tabPageMed";
            this.tabPageMed.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMed.Size = new System.Drawing.Size(1333, 789);
            this.tabPageMed.TabIndex = 1;
            this.tabPageMed.Text = "Medições";
            this.tabPageMed.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSensor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1333, 789);
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
            this.dataGridViewSensor.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSensor.Name = "dataGridViewSensor";
            this.dataGridViewSensor.RowHeadersWidth = 62;
            this.dataGridViewSensor.Size = new System.Drawing.Size(1269, 770);
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
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Dado 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 65;
            this.button1.Text = "teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1344, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Supervisório - Especialização";
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}


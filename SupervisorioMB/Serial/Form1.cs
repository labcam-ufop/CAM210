using System;
using System.Windows.Forms;
using System.IO.Ports;
using EasyModbus;

namespace Serial
{
    public partial class Form1 : Form
    {

        //VARIÁVEIS
        string InputData = String.Empty;
        ModbusClient clientModBus;

        public Form1()
        {
            InitializeComponent();


            //obter as portas COM disponíveis
            String[] ports = SerialPort.GetPortNames();
            // adicionar as portas ao combobox
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            // try to open the selected port:
            try
            {
                clientModBus = new ModbusClient(comboBox1.SelectedItem.ToString());
                clientModBus.Connect();
                timer1.Enabled=true;
            }
            // give a message, if the port is not available:
            catch
            {
                MessageBox.Show("A porta serial " + serialPort1.PortName +
                   " não pode ser aberta", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.SelectedText = "";
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(textBoxSaida.Text);                
            }
            else MessageBox.Show("A porta serial está fechada!",
                                 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxSaida.Clear();

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEntrada.Clear();
        }
        

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            //obter as portas COM disponíveis
            String[] ports = SerialPort.GetPortNames();
            // adicionar as portas ao combobox
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sobre = new Form2();
            sobre.Show();
        }

        private void btLiga_Click(object sender, EventArgs e)
        {
            try
            {
                clientModBus.WriteSingleCoil(0, true);
            }
            catch 
            {
            }
        }

        private void btdesliga_Click(object sender, EventArgs e)
        {
            try
            {
                clientModBus.WriteSingleCoil(0, false);
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (clientModBus != null)
                {
                    int[] registradores = clientModBus.ReadHoldingRegisters(1, 4);
                    label1.Text = registradores[0].ToString();
                    label2.Text = registradores[1].ToString();
                    label3.Text = registradores[2].ToString();
                    label8.Text = registradores[3].ToString();
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clientModBus.WriteSingleRegister(1, 210);
                clientModBus.WriteSingleRegister(2, 113);
                clientModBus.WriteSingleRegister(3, 2021);
                clientModBus.WriteSingleRegister(4, 1023);
            }
            catch { }
        }
    }
}

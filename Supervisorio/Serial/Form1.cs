using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial
{
    public partial class Form1 : Form
    {

        //VARIÁVEIS
        string InputData = String.Empty;


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
            serialPort1.PortName = comboBox1.SelectedItem.ToString();

            // try to open the selected port:
            try
            {
                serialPort1.Open();
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
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //RECEBE STRING
            InputData = serialPort1.ReadLine(); 
            this.Invoke(new EventHandler(DisplayText));
        }
        private void DisplayText(object sender, EventArgs e)
        {
            string input, adc1;
            int i = 0;
            //textBoxEntrada.Clear();
            textBoxEntrada.AppendText(InputData);
            input = InputData.ToString();
            try
            {
                // Trata dados da string recebida /*0000/
                if (input != string.Empty)
                {
                    i = input.IndexOf("*"); //Obtem índice onde aparece *
                    adc1 = input.Substring(i + 1, 4); // captura 4 bytes após * (0000)
                    label1.Text = adc1; // passa valor para o label1
                    aChart1.Series["Temperatura"].Points.AddY(adc1); // escreve no gráfico
                                                                     // Escreve na tabela do DataGridView
                    var row = new DataGridViewRow();
                    row.CreateCells(dataGridViewSensor);
                    row.Cells[0].Value = adc1;
                    row.Cells[1].Value = "variável 2";
                    row.Cells[2].Value = "variável 3";
                    row.Cells[3].Value = "variável 4";
                    row.Cells[4].Value = "variável 5";
                    row.Cells[5].Value = "variável 6";
                    dataGridViewSensor.Rows.Add(row);
                }
            }
            catch { }
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

            serialPort1.WriteLine("liga");
        }

        private void btdesliga_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("d");
        }
    }
}

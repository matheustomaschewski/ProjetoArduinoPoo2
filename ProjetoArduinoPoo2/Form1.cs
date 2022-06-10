using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProjetoArduinoPoo2
{
    public partial class Form1 : Form
    {

        SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = false;

            cbPortaCom.Items.AddRange(SerialPort.GetPortNames());

            if (cbPortaCom.Items.Count > 0)
            {
                cbPortaCom.SelectedIndex = 0;
            }

            cbBoudRate.SelectedIndex = 5;

            //chartLDR.ChartAreas[0].AxisX.Maximum = 30;
            chartLDR.ChartAreas[0].AxisY.Minimum = -10;
            chartLDR.ChartAreas[0].AxisY.Maximum = 1200;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
                return;
            }
            else
            {
                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;

                serialPort.PortName = cbPortaCom.Text;
                serialPort.BaudRate = Int32.Parse(cbBoudRate.Text);

                try
                {
                    serialPort.Open();
                    TimerSerial.Interval = 1000;
                    TimerSerial.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }  
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnConectar.Enabled = true;
                btnDesconectar.Enabled = false;

                TimerSerial.Stop();
            }
        }

        int i = 0;
        private void TimerSerial_Tick(object sender, EventArgs e)
        {
            string serialIn = serialPort.ReadLine();
            string serialRam;

            TextBox tb = new TextBox();
            tb.Multiline = true;
            tb.Text = serialIn;

            serialRam = tb.Lines[0];

            lbSerial.Text = "LDR (valor): " + serialRam;

            i++;
            chartLDR.Series[0].Points.AddXY(i, serialRam);

        }
    }
}

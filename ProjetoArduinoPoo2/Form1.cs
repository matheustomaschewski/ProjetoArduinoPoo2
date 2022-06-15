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
using System.IO;
using System.Diagnostics;

namespace ProjetoArduinoPoo2
{
    public partial class Form1 : Form
    {

        SerialPort serialPort = new SerialPort();
        int intervalo = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = false;
            BtnGravar.Enabled = false;

            cbPortaCom.Items.AddRange(SerialPort.GetPortNames());

            if (cbPortaCom.Items.Count > 0)
            {
                cbPortaCom.SelectedIndex = 0;
            }

            cbBoudRate.SelectedIndex = 5;

            for(int i = 0; i == 30; i++)
            {
                string hora = DateTime.Now.ToLongTimeString();
                chartLDR.Series[0].Points.AddXY(hora, 0);
                if(chartLDR.Series[0].Points.Count == 50)
                {
                    chartLDR.Series[0].Points.RemoveAt(0);
                }
            }

            chartLDR.ChartAreas[0].AxisY.Minimum = 850;
            chartLDR.ChartAreas[0].AxisY.Maximum = 1100;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
                BtnGravar.Enabled = false;
                return;
            }
            else
            {
                if(!(cbPortaCom.SelectedIndex > -1) || !(cbBoudRate.SelectedIndex > -1))
                {
                    return;
                }
                else
                {

                    btnDesconectar.Enabled = true;
                    btnConectar.Enabled = false;
                    //BtnGravar.Enabled = true;

                    serialPort.PortName = cbPortaCom.Text;
                    serialPort.BaudRate = Int32.Parse(cbBoudRate.Text);

                    try
                    {
                        chartLDR.Series[0].Points.Clear();

                        serialPort.Open();
                        TimerSerial.Interval = intervalo;
                        TimerSerial.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
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
                BtnGravar.Enabled = false;

                TimerSerial.Stop();
                TimerLog.Stop();

                serialPort.Close();
            }
        }

        string serialRam;

        private void TimerSerial_Tick(object sender, EventArgs e)
        {

            var serialIn = serialPort.ReadLine();
            

            TextBox tb = new TextBox();
            tb.Multiline = true;
            tb.Text = serialIn;

            if(tb.Lines.Length > 0)
            {
                serialRam = tb.Lines[0];

                lbSerial.Text = "LDR (valor): " + serialRam;

                //string hora = DateTime.Now.ToLongTimeString();
                //chartLDR.Series[0].Points.AddXY(hora, serialRam);

                string hora = DateTime.Now.ToLongTimeString();
                chartLDR.Series[0].Points.AddXY(hora, serialRam);
                if (chartLDR.Series[0].Points.Count == 50)
                {
                    chartLDR.Series[0].Points.RemoveAt(0);
                }

            }
            

            //SalvarNoTxt(serialRam);

        }

        private async Task SalvarNoTxt(string Dados)
        {

            Stopwatch crono = new Stopwatch();
            crono.Start();

            string dataHora = DateTime.Now.ToString();
            string texto = $"[{dataHora}] - {Dados}";

            string caminho = Path.Combine(TxtLocal.Text, "DadosLidos.txt");

            StreamWriter arquivo = new StreamWriter(caminho, true);

            if (File.Exists(caminho))
            {
                try
                {
                    await arquivo.WriteLineAsync(texto);
                    //arquivo.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally { arquivo.Close(); }
            }
            else
            {
                try
                {
                    arquivo = File.CreateText(caminho);
                    await arquivo.WriteLineAsync(texto);
                    //arquivo.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally { arquivo.Close(); }
                
            }

            crono.Stop();
            LbTempo.Text = $"Tempo salvar dados: {crono.Elapsed.TotalMilliseconds} ms";

            //StreamWriter arquivo = new StreamWriter(caminho);
            //arquivo.WriteLine(texto);

        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdl = new FolderBrowserDialog();
            DialogResult result = fdl.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fdl.SelectedPath))
            {
                TxtLocal.Text = fdl.SelectedPath.ToString();
                BtnGravar.Enabled = true;
            }

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if(TxtLocal.TextLength == 0)
            {
                MessageBox.Show("Por favor clique no botão 'Local' e selecione um local para salvar o arquivo Txt.");
                BtnGravar.Enabled = false;
            }
            else
            {
                if(serialPort.IsOpen)
                {
                    TimerLog.Interval = intervalo;
                    TimerLog.Start();
                    BtnGravar.Enabled = false;
                }
            }
        }

        private async void TimerLog_Tick(object sender, EventArgs e)
        {
            await SalvarNoTxt(serialRam);
        }

        //private async Task MetodoSalvar(string dados)
        //{
        //    await SalvarNoTxt(dados);
        //}
    }
}

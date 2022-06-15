
namespace ProjetoArduinoPoo2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.lbSerial = new System.Windows.Forms.Label();
            this.cbBoudRate = new System.Windows.Forms.ComboBox();
            this.cbPortaCom = new System.Windows.Forms.ComboBox();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbPortaCom = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.chartLDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimerSerial = new System.Windows.Forms.Timer(this.components);
            this.TimerLog = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BtnGravar = new System.Windows.Forms.Button();
            this.TxtLocal = new System.Windows.Forms.TextBox();
            this.BtnLocal = new System.Windows.Forms.Button();
            this.LbTempo = new System.Windows.Forms.Label();
            this.gbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLDR)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConfig.Controls.Add(this.LbTempo);
            this.gbConfig.Controls.Add(this.BtnLocal);
            this.gbConfig.Controls.Add(this.TxtLocal);
            this.gbConfig.Controls.Add(this.BtnGravar);
            this.gbConfig.Controls.Add(this.lbSerial);
            this.gbConfig.Controls.Add(this.cbBoudRate);
            this.gbConfig.Controls.Add(this.cbPortaCom);
            this.gbConfig.Controls.Add(this.lbBaudRate);
            this.gbConfig.Controls.Add(this.lbPortaCom);
            this.gbConfig.Controls.Add(this.btnDesconectar);
            this.gbConfig.Controls.Add(this.btnConectar);
            this.gbConfig.Location = new System.Drawing.Point(12, 10);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(2);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(2);
            this.gbConfig.Size = new System.Drawing.Size(881, 171);
            this.gbConfig.TabIndex = 0;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Configurações";
            // 
            // lbSerial
            // 
            this.lbSerial.AutoSize = true;
            this.lbSerial.Location = new System.Drawing.Point(374, 60);
            this.lbSerial.Name = "lbSerial";
            this.lbSerial.Size = new System.Drawing.Size(134, 23);
            this.lbSerial.TabIndex = 6;
            this.lbSerial.Text = "LDR (valor): 0";
            // 
            // cbBoudRate
            // 
            this.cbBoudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoudRate.FormattingEnabled = true;
            this.cbBoudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.cbBoudRate.Location = new System.Drawing.Point(8, 128);
            this.cbBoudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cbBoudRate.Name = "cbBoudRate";
            this.cbBoudRate.Size = new System.Drawing.Size(162, 31);
            this.cbBoudRate.TabIndex = 5;
            // 
            // cbPortaCom
            // 
            this.cbPortaCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortaCom.FormattingEnabled = true;
            this.cbPortaCom.Location = new System.Drawing.Point(8, 70);
            this.cbPortaCom.Margin = new System.Windows.Forms.Padding(2);
            this.cbPortaCom.Name = "cbPortaCom";
            this.cbPortaCom.Size = new System.Drawing.Size(162, 31);
            this.cbPortaCom.TabIndex = 4;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(4, 103);
            this.lbBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(109, 23);
            this.lbBaudRate.TabIndex = 3;
            this.lbBaudRate.Text = "Baud Rate:";
            // 
            // lbPortaCom
            // 
            this.lbPortaCom.AutoSize = true;
            this.lbPortaCom.Location = new System.Drawing.Point(4, 45);
            this.lbPortaCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPortaCom.Name = "lbPortaCom";
            this.lbPortaCom.Size = new System.Drawing.Size(117, 23);
            this.lbPortaCom.TabIndex = 2;
            this.lbPortaCom.Text = "Porta COM:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(199, 86);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(161, 55);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(199, 27);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(161, 55);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // chartLDR
            // 
            this.chartLDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartLDR.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartLDR.Legends.Add(legend2);
            this.chartLDR.Location = new System.Drawing.Point(12, 186);
            this.chartLDR.Name = "chartLDR";
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBorderWidth = 10;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 5;
            series2.Name = "LDR";
            this.chartLDR.Series.Add(series2);
            this.chartLDR.Size = new System.Drawing.Size(881, 518);
            this.chartLDR.TabIndex = 1;
            this.chartLDR.Text = "chart1";
            // 
            // TimerSerial
            // 
            this.TimerSerial.Tick += new System.EventHandler(this.TimerSerial_Tick);
            // 
            // TimerLog
            // 
            this.TimerLog.Tick += new System.EventHandler(this.TimerLog_Tick);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(715, 86);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(161, 55);
            this.BtnGravar.TabIndex = 7;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TxtLocal
            // 
            this.TxtLocal.Location = new System.Drawing.Point(378, 27);
            this.TxtLocal.Name = "TxtLocal";
            this.TxtLocal.ReadOnly = true;
            this.TxtLocal.Size = new System.Drawing.Size(426, 30);
            this.TxtLocal.TabIndex = 8;
            // 
            // BtnLocal
            // 
            this.BtnLocal.Location = new System.Drawing.Point(810, 26);
            this.BtnLocal.Name = "BtnLocal";
            this.BtnLocal.Size = new System.Drawing.Size(66, 30);
            this.BtnLocal.TabIndex = 9;
            this.BtnLocal.Text = "Local";
            this.BtnLocal.UseVisualStyleBackColor = true;
            this.BtnLocal.Click += new System.EventHandler(this.BtnLocal_Click);
            // 
            // LbTempo
            // 
            this.LbTempo.AutoSize = true;
            this.LbTempo.Location = new System.Drawing.Point(374, 103);
            this.LbTempo.Name = "LbTempo";
            this.LbTempo.Size = new System.Drawing.Size(331, 23);
            this.LbTempo.TabIndex = 10;
            this.LbTempo.Text = "Tempo salvar dados: [não calculado]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 716);
            this.Controls.Add(this.chartLDR);
            this.Controls.Add(this.gbConfig);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POO - Projeto Arduino C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.ComboBox cbBoudRate;
        private System.Windows.Forms.ComboBox cbPortaCom;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbPortaCom;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLDR;
        private System.Windows.Forms.Timer TimerSerial;
        private System.Windows.Forms.Timer TimerLog;
        private System.Windows.Forms.Label lbSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.TextBox TxtLocal;
        private System.Windows.Forms.Button BtnLocal;
        private System.Windows.Forms.Label LbTempo;
    }
}


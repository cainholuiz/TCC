namespace WindowsFormsApplication1
{
    partial class tela_inicial
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(41611D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_volta = new System.Windows.Forms.Button();
            this.bt_Envia = new System.Windows.Forms.Button();
            this.tB_longitude = new System.Windows.Forms.TextBox();
            this.tB_latitude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_longitude = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_lattitude = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbConexao = new System.Windows.Forms.GroupBox();
            this.bt_VP = new System.Windows.Forms.Button();
            this.bt_Desconectar = new System.Windows.Forms.Button();
            this.labelPortasDisponiveis = new System.Windows.Forms.Label();
            this.bt_Conectar = new System.Windows.Forms.Button();
            this.cb_portas = new System.Windows.Forms.ComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabelTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gB_temperatura = new System.Windows.Forms.GroupBox();
            this.chart_temperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tB_temperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_umidade = new System.Windows.Forms.GroupBox();
            this.chart_umidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tB_umi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bt_para = new System.Windows.Forms.Button();
            this.bt_grava = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbConexao.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gB_temperatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temperatura)).BeginInit();
            this.gB_umidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_umidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(392, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 128);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordenadas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_volta);
            this.groupBox3.Controls.Add(this.bt_Envia);
            this.groupBox3.Controls.Add(this.tB_longitude);
            this.groupBox3.Controls.Add(this.tB_latitude);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(201, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecionada";
            // 
            // bt_volta
            // 
            this.bt_volta.Location = new System.Drawing.Point(195, 61);
            this.bt_volta.Name = "bt_volta";
            this.bt_volta.Size = new System.Drawing.Size(75, 23);
            this.bt_volta.TabIndex = 11;
            this.bt_volta.Text = "Voltar";
            this.bt_volta.UseVisualStyleBackColor = true;
            this.bt_volta.Click += new System.EventHandler(this.bt_volta_Click);
            // 
            // bt_Envia
            // 
            this.bt_Envia.Location = new System.Drawing.Point(195, 26);
            this.bt_Envia.Name = "bt_Envia";
            this.bt_Envia.Size = new System.Drawing.Size(75, 23);
            this.bt_Envia.TabIndex = 10;
            this.bt_Envia.Text = "Enviar";
            this.bt_Envia.UseVisualStyleBackColor = true;
            // 
            // tB_longitude
            // 
            this.tB_longitude.Location = new System.Drawing.Point(64, 60);
            this.tB_longitude.Name = "tB_longitude";
            this.tB_longitude.Size = new System.Drawing.Size(100, 20);
            this.tB_longitude.TabIndex = 6;
            // 
            // tB_latitude
            // 
            this.tB_latitude.Location = new System.Drawing.Point(64, 28);
            this.tB_latitude.Name = "tB_latitude";
            this.tB_latitude.Size = new System.Drawing.Size(100, 20);
            this.tB_latitude.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Longitude: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Latitude:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label_longitude);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label_lattitude);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(9, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 90);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oeste";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_longitude.Location = new System.Drawing.Point(67, 63);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(0, 13);
            this.label_longitude.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Longitude: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sul";
            // 
            // label_lattitude
            // 
            this.label_lattitude.AutoSize = true;
            this.label_lattitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lattitude.Location = new System.Drawing.Point(67, 20);
            this.label_lattitude.Name = "label_lattitude";
            this.label_lattitude.Size = new System.Drawing.Size(0, 13);
            this.label_lattitude.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Latitude:";
            // 
            // gbConexao
            // 
            this.gbConexao.AutoSize = true;
            this.gbConexao.Controls.Add(this.bt_VP);
            this.gbConexao.Controls.Add(this.bt_Desconectar);
            this.gbConexao.Controls.Add(this.labelPortasDisponiveis);
            this.gbConexao.Controls.Add(this.bt_Conectar);
            this.gbConexao.Controls.Add(this.cb_portas);
            this.gbConexao.Location = new System.Drawing.Point(6, 27);
            this.gbConexao.Name = "gbConexao";
            this.gbConexao.Size = new System.Drawing.Size(355, 128);
            this.gbConexao.TabIndex = 14;
            this.gbConexao.TabStop = false;
            this.gbConexao.Text = "Conexão";
            // 
            // bt_VP
            // 
            this.bt_VP.Location = new System.Drawing.Point(87, 56);
            this.bt_VP.Margin = new System.Windows.Forms.Padding(2);
            this.bt_VP.Name = "bt_VP";
            this.bt_VP.Size = new System.Drawing.Size(181, 23);
            this.bt_VP.TabIndex = 8;
            this.bt_VP.Text = "Verificar Portas";
            this.bt_VP.UseVisualStyleBackColor = true;
            this.bt_VP.Click += new System.EventHandler(this.bt_VP_Click);
            // 
            // bt_Desconectar
            // 
            this.bt_Desconectar.Enabled = false;
            this.bt_Desconectar.Location = new System.Drawing.Point(186, 84);
            this.bt_Desconectar.Name = "bt_Desconectar";
            this.bt_Desconectar.Size = new System.Drawing.Size(158, 25);
            this.bt_Desconectar.TabIndex = 3;
            this.bt_Desconectar.Text = "Desconectar";
            this.bt_Desconectar.UseVisualStyleBackColor = true;
            this.bt_Desconectar.Click += new System.EventHandler(this.bt_Desconectar_Click);
            // 
            // labelPortasDisponiveis
            // 
            this.labelPortasDisponiveis.AutoSize = true;
            this.labelPortasDisponiveis.Location = new System.Drawing.Point(6, 22);
            this.labelPortasDisponiveis.Name = "labelPortasDisponiveis";
            this.labelPortasDisponiveis.Size = new System.Drawing.Size(97, 13);
            this.labelPortasDisponiveis.TabIndex = 2;
            this.labelPortasDisponiveis.Text = "Portas disponíveis:";
            // 
            // bt_Conectar
            // 
            this.bt_Conectar.Location = new System.Drawing.Point(9, 84);
            this.bt_Conectar.Name = "bt_Conectar";
            this.bt_Conectar.Size = new System.Drawing.Size(158, 25);
            this.bt_Conectar.TabIndex = 1;
            this.bt_Conectar.Text = "Conectar";
            this.bt_Conectar.UseVisualStyleBackColor = true;
            this.bt_Conectar.Click += new System.EventHandler(this.bt_Conectar_Click);
            // 
            // cb_portas
            // 
            this.cb_portas.FormattingEnabled = true;
            this.cb_portas.Location = new System.Drawing.Point(109, 19);
            this.cb_portas.Name = "cb_portas";
            this.cb_portas.Size = new System.Drawing.Size(136, 21);
            this.cb_portas.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelTitulo,
            this.statusLabel,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 532);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(887, 22);
            this.statusBar.TabIndex = 16;
            // 
            // statusLabelTitulo
            // 
            this.statusLabelTitulo.Name = "statusLabelTitulo";
            this.statusLabelTitulo.Size = new System.Drawing.Size(45, 17);
            this.statusLabelTitulo.Text = "Status: ";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(82, 17);
            this.statusLabel.Text = "Desconhecido";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.dadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dadosToolStripMenuItem.Text = "Visualizar dados";
            this.dadosToolStripMenuItem.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // gB_temperatura
            // 
            this.gB_temperatura.AutoSize = true;
            this.gB_temperatura.Controls.Add(this.chart_temperatura);
            this.gB_temperatura.Controls.Add(this.tB_temperatura);
            this.gB_temperatura.Controls.Add(this.label1);
            this.gB_temperatura.Location = new System.Drawing.Point(392, 167);
            this.gB_temperatura.Name = "gB_temperatura";
            this.gB_temperatura.Size = new System.Drawing.Size(355, 354);
            this.gB_temperatura.TabIndex = 18;
            this.gB_temperatura.TabStop = false;
            this.gB_temperatura.Text = "Temperatura";
            // 
            // chart_temperatura
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_temperatura.ChartAreas.Add(chartArea1);
            this.chart_temperatura.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_temperatura.Legends.Add(legend1);
            this.chart_temperatura.Location = new System.Drawing.Point(9, 51);
            this.chart_temperatura.Name = "chart_temperatura";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            dataPoint1.IsEmpty = true;
            series1.Points.Add(dataPoint1);
            series1.ToolTip = "#VAL";
            this.chart_temperatura.Series.Add(series1);
            this.chart_temperatura.Size = new System.Drawing.Size(289, 284);
            this.chart_temperatura.TabIndex = 21;
            this.chart_temperatura.Text = "chart1";
            // 
            // tB_temperatura
            // 
            this.tB_temperatura.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_temperatura.Location = new System.Drawing.Point(67, 25);
            this.tB_temperatura.Name = "tB_temperatura";
            this.tB_temperatura.Size = new System.Drawing.Size(100, 20);
            this.tB_temperatura.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Leitura: ";
            // 
            // gB_umidade
            // 
            this.gB_umidade.AutoSize = true;
            this.gB_umidade.Controls.Add(this.chart_umidade);
            this.gB_umidade.Controls.Add(this.tB_umi);
            this.gB_umidade.Controls.Add(this.label2);
            this.gB_umidade.Location = new System.Drawing.Point(6, 167);
            this.gB_umidade.Name = "gB_umidade";
            this.gB_umidade.Size = new System.Drawing.Size(355, 354);
            this.gB_umidade.TabIndex = 19;
            this.gB_umidade.TabStop = false;
            this.gB_umidade.Text = "Umidade";
            // 
            // chart_umidade
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_umidade.ChartAreas.Add(chartArea2);
            this.chart_umidade.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_umidade.Legends.Add(legend2);
            this.chart_umidade.Location = new System.Drawing.Point(9, 51);
            this.chart_umidade.Name = "chart_umidade";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Umidade";
            dataPoint2.IsEmpty = true;
            series2.Points.Add(dataPoint2);
            this.chart_umidade.Series.Add(series2);
            this.chart_umidade.Size = new System.Drawing.Size(289, 284);
            this.chart_umidade.TabIndex = 2;
            this.chart_umidade.Text = "chart1";
            // 
            // tB_umi
            // 
            this.tB_umi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tB_umi.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_umi.Location = new System.Drawing.Point(67, 25);
            this.tB_umi.Name = "tB_umi";
            this.tB_umi.Size = new System.Drawing.Size(100, 20);
            this.tB_umi.TabIndex = 0;
            this.tB_umi.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Leitura:";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // bt_para
            // 
            this.bt_para.Location = new System.Drawing.Point(774, 300);
            this.bt_para.Name = "bt_para";
            this.bt_para.Size = new System.Drawing.Size(75, 23);
            this.bt_para.TabIndex = 25;
            this.bt_para.Text = "Para";
            this.bt_para.UseVisualStyleBackColor = true;
            // 
            // bt_grava
            // 
            this.bt_grava.Location = new System.Drawing.Point(774, 271);
            this.bt_grava.Name = "bt_grava";
            this.bt_grava.Size = new System.Drawing.Size(75, 23);
            this.bt_grava.TabIndex = 24;
            this.bt_grava.Text = "Grava";
            this.bt_grava.UseVisualStyleBackColor = true;
            this.bt_grava.Click += new System.EventHandler(this.bt_grava_Click);
            // 
            // tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(887, 554);
            this.Controls.Add(this.bt_para);
            this.Controls.Add(this.bt_grava);
            this.Controls.Add(this.gB_umidade);
            this.Controls.Add(this.gB_temperatura);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbConexao);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tela_inicial";
            this.Text = "Controle Helicóptero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tela_inicial_FormClosed);
            this.Load += new System.EventHandler(this.tela_inicial_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbConexao.ResumeLayout(false);
            this.gbConexao.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gB_temperatura.ResumeLayout(false);
            this.gB_temperatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temperatura)).EndInit();
            this.gB_umidade.ResumeLayout(false);
            this.gB_umidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_umidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_volta;
        private System.Windows.Forms.Button bt_Envia;
        private System.Windows.Forms.TextBox tB_longitude;
        private System.Windows.Forms.TextBox tB_latitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_longitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_lattitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbConexao;
        private System.Windows.Forms.Button bt_VP;
        private System.Windows.Forms.Button bt_Desconectar;
        private System.Windows.Forms.Label labelPortasDisponiveis;
        private System.Windows.Forms.Button bt_Conectar;
        private System.Windows.Forms.ComboBox cb_portas;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTitulo;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox gB_temperatura;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temperatura;
        private System.Windows.Forms.TextBox tB_temperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB_umidade;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_umidade;
        private System.Windows.Forms.TextBox tB_umi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bt_para;
        private System.Windows.Forms.Button bt_grava;

    }
}


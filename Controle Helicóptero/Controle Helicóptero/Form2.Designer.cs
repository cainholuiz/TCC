namespace WindowsFormsApplication1
{
    partial class tela_visualiza
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_leitura_temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_leitura_umidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_arquivo = new System.Windows.Forms.TextBox();
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bt_plot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_leitura_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_leitura_umidade)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_leitura_temp
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_leitura_temp.ChartAreas.Add(chartArea1);
            legend1.Name = "Temperatura";
            this.chart_leitura_temp.Legends.Add(legend1);
            this.chart_leitura_temp.Location = new System.Drawing.Point(12, 79);
            this.chart_leitura_temp.Name = "chart_leitura_temp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Temperatura";
            series1.Name = "Temperatura";
            this.chart_leitura_temp.Series.Add(series1);
            this.chart_leitura_temp.Size = new System.Drawing.Size(300, 300);
            this.chart_leitura_temp.TabIndex = 0;
            this.chart_leitura_temp.Text = "chart1";
            // 
            // chart_leitura_umidade
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_leitura_umidade.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_leitura_umidade.Legends.Add(legend2);
            this.chart_leitura_umidade.Location = new System.Drawing.Point(340, 79);
            this.chart_leitura_umidade.Name = "chart_leitura_umidade";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Umidade";
            this.chart_leitura_umidade.Series.Add(series2);
            this.chart_leitura_umidade.Size = new System.Drawing.Size(300, 300);
            this.chart_leitura_umidade.TabIndex = 1;
            this.chart_leitura_umidade.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arquivo:";
            // 
            // tB_arquivo
            // 
            this.tB_arquivo.Location = new System.Drawing.Point(64, 29);
            this.tB_arquivo.Name = "tB_arquivo";
            this.tB_arquivo.Size = new System.Drawing.Size(263, 20);
            this.tB_arquivo.TabIndex = 3;
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Location = new System.Drawing.Point(356, 26);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.bt_pesquisa.TabIndex = 4;
            this.bt_pesquisa.Text = "Pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Txt files|*.txt|All files|*.* ";
            // 
            // bt_plot
            // 
            this.bt_plot.Location = new System.Drawing.Point(452, 26);
            this.bt_plot.Name = "bt_plot";
            this.bt_plot.Size = new System.Drawing.Size(75, 23);
            this.bt_plot.TabIndex = 5;
            this.bt_plot.Text = "Plotar";
            this.bt_plot.UseVisualStyleBackColor = true;
            this.bt_plot.Click += new System.EventHandler(this.bt_plot_Click);
            // 
            // tela_visualiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 398);
            this.Controls.Add(this.bt_plot);
            this.Controls.Add(this.bt_pesquisa);
            this.Controls.Add(this.tB_arquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_leitura_umidade);
            this.Controls.Add(this.chart_leitura_temp);
            this.Name = "tela_visualiza";
            this.Text = "Leitura de dados";
            ((System.ComponentModel.ISupportInitialize)(this.chart_leitura_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_leitura_umidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_leitura_temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_leitura_umidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_arquivo;
        private System.Windows.Forms.Button bt_pesquisa;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button bt_plot;
    }
}
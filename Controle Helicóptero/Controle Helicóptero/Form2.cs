using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class tela_visualiza : Form
    {
        DialogResult dr;
        string arquivo;
        string dados;
        string temp;
        string umid;

        int X = 0;

        public tela_visualiza()
        {
            InitializeComponent();
            chart_leitura_temp.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_leitura_umidade.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            dr = this.openFileDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                arquivo = openFileDialog.FileName;
                tB_arquivo.Text = arquivo;
            }
                

        }

        private void bt_plot_Click(object sender, EventArgs e)
        {
            StreamReader str = new StreamReader(arquivo);

            while ((dados = str.ReadLine()) !=null)
            {
                
                temp = dados.Substring(dados.IndexOf("T") + 1, dados.IndexOf("U") - 1);
                umid = dados.Substring(dados.IndexOf("U") + 1);
                

                Decimal temperatura = Convert.ToDecimal(temp);
                Double umidade = Convert.ToDouble(umid);

                chart_leitura_temp.Series[0].Points.AddXY(X,temperatura);
                chart_leitura_umidade.Series[0].Points.AddXY(X,umidade);
                chart_leitura_umidade.Update();
                chart_leitura_temp.Update();

           }
        
        }
            
        }
    
}

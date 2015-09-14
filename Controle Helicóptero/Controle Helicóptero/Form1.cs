using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace WindowsFormsApplication1
{
    
    public partial class tela_inicial : Form
    {

        SerialPort porta;   //Instanciando a porta serial.
        string[] portas;    //Variável das portas disponíveis

        StreamWriter wr;
        string entrada;
        string temp;
        string umid;

        string latitude;
        string longitude;
        string lat_base;
        string lon_base;

        // delegate is used to write to a UI control from a non-UI thread
        private delegate void SetTextDeleg(string text);

        int x = 0;

        public tela_inicial()
        {
            InitializeComponent();
            permissoes(false, false, false, true, false, false, false, false);
            porta = new SerialPort();
            chart_temperatura.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_umidade.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        //Verifica as portas que estão disponíveis e mostra nos ComboBox
        private void portas_disponiveis()
        {
            portas = SerialPort.GetPortNames();

            if (portas.Length > 0)
            {
                cb_portas.Items.Clear();
                cb_portas.SelectedIndex = -1;
                //cb_BR.SelectedIndex = -1;

                foreach (string s in SerialPort.GetPortNames())
                {
                    cb_portas.Items.Add(s);
                }
                defineStatus(false);   //Definição da condição da Barra de Status
                permissoes(true, true, false, true,false, false, false, false);   //
            }

            else
            {
                defineStatus(false);
                permissoes(false, false, false, true, false, false, false, false);

            }
        }
        private void defineStatus(bool status)
        {
            if (status == true)
            {
                statusLabel.Text = "Conectado";
                statusLabel.ForeColor = Color.Green;
            }
            else
            {
                statusLabel.Text = "Desconectado";
                statusLabel.ForeColor = Color.Red;
            }
        }

        private void permissoes(bool portas, bool conectar, bool desconectar,
                 bool verifica, bool latitude, bool longitude, bool envia, bool apaga)
        {
            cb_portas.Enabled = portas;
            bt_Conectar.Enabled = conectar;
            bt_Desconectar.Enabled = desconectar;
           // cb_BR.Enabled = baudrate;
            bt_VP.Enabled = verifica;
            tB_latitude.Enabled = latitude;
            tB_longitude.Enabled = longitude;
            bt_Envia.Enabled = envia;
            bt_volta.Enabled = apaga;

        }

       
        private void bt_Desconectar_Click(object sender, EventArgs e)
        {
            if (porta != null && porta.IsOpen)
            {
                porta.Close();
                porta = null;
                defineStatus(false);
                portas_disponiveis();
            }
        }

        private void bt_Conectar_Click(object sender, EventArgs e)
        {
            if (cb_portas.SelectedIndex != -1)
            {
                porta.PortName = cb_portas.SelectedItem.ToString();
                porta.BaudRate = 9600;
            }
            else
            {
                throw new Exception("Selecinar a Porta e o Baud Rate para comunicação.");
            }

            if (!porta.IsOpen)
            {
                porta.Open();
                permissoes(false, false, true, false, true, true, true, true);
                defineStatus(true);
            }

        }

        private void bt_VP_Click(object sender, EventArgs e)
        {
            portas_disponiveis();
        }

        private void tela_inicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (porta != null && porta.IsOpen)
            {
                porta.Close();
                porta = null;
                defineStatus(false);
                portas_disponiveis();
            }
        }

        private void bt_Envia_Click(object sender, EventArgs e)
        {
            porta.WriteLine("A" + tB_latitude + "O" + tB_longitude);
           
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aparece(false,false,false,false,false);
        }

        
        private void aparece(bool tem,bool umi,bool grava,bool stop,bool tempo)
        {
            
            gB_temperatura.Enabled = tem;
            gB_umidade.Enabled = umi;
            bt_grava.Enabled = grava;
            bt_para.Enabled = stop;
            timer.Enabled = tempo;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_Desconectar_Click(sender, e);
            conectarToolStripMenuItem_Click(sender, e);
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {          
            Thread.Sleep(500);
            entrada = porta.ReadLine();
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { entrada });
        }

        private void si_DataReceived(string entrada)
        {
            //Dá uma olhada nessa parte!!!
            if (entrada.StartsWith("T"))
            {
                temp = entrada.Substring(entrada.IndexOf("T") + 1, entrada.IndexOf("U") - 1);
                umid = entrada.Substring(entrada.IndexOf("U") + 1);
                tB_temperatura.Text = temp.Trim();
                tB_umi.Text = umid.Trim();
            }
            
            if (entrada.StartsWith("A"))
            {
                latitude = entrada.Substring(entrada.IndexOf("A") + 1, entrada.IndexOf("O") - 1);
                longitude = entrada.Substring(entrada.IndexOf("O") + 1);
                label_lattitude.Text = latitude.ToString();
                label_longitude.Text = longitude.ToString();
                
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Decimal temperatura = Convert.ToDecimal(temp);
            Decimal umidade = Convert.ToDecimal(umid);
            if (chart_temperatura.Series[0].Points.Count > 6)
            {
                chart_temperatura.Series[0].Points.RemoveAt(0);
                chart_temperatura.Update();
            }
            if (chart_umidade.Series[0].Points.Count > 6)
            {
                chart_umidade.Series[0].Points.RemoveAt(0);
                chart_umidade.Update();
            }

            chart_temperatura.Series[0].Points.AddXY(x++,temperatura);
            chart_umidade.Series[0].Points.AddXY(x++,umidade);

        }


        private void tela_inicial_Load(object sender, EventArgs e)
        {
            porta.Handshake = Handshake.None;
            porta.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            porta.ReadTimeout = 500;
            porta.WriteTimeout = 500;
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_visualiza tv = new tela_visualiza();
            tv.Show();
        }

        private void bt_grava_Click(object sender, EventArgs e)
        {
      //      " + DateTime.Now.ToString("dd-MM-yyyy-hh-mm") + "
            wr = new StreamWriter(@"C:\Users\User\Desktop\"+ DateTime.Now.ToString("dd-MM-yyyy-hh-mm") + ".txt", true);
           wr.WriteLine("T" + temp + "U" + umid);
                      
        }

        private void bt_para_Click(object sender, EventArgs e,StreamWriter wr)
        {
            wr.Close();
        }

        private void bt_volta_Click(object sender, EventArgs e)
        {

        }


    }
}

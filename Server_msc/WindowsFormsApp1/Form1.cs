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

namespace WindowsFormsApp1
{
    public partial class frmMainServer : Form
    {
        // Colori rispettivi status
        #region 
        public Color StatoDownRed = Color.Red;
        public Color StatoUpGreen = Color.Green;
        public Color StatoSuspendYellow = Color.Yellow;
        #endregion  

        private static bool StatusServer;
        private Myrs232c myRs232;
        private static string[] arrInterrogazioni = new string[] { };
        private static int k = 0;
        private Database DbIsii = new Database("ISII");
        private Database DbTramello = new Database("Tramello");
        List<Database> ElencoDB;
        

        public frmMainServer()
        {
            InitializeComponent();
        }

        private void frmMainServer_Load(object sender, EventArgs e)
        {
            myRs232 = new Myrs232c();
            ElencoDB = new List<Database>();
            ElencoDB.Add(DbIsii);
            ElencoDB.Add(DbTramello);
            PanelStatus.BackColor = StatoDownRed;
            StatusServer = false;

        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            PanelStatus.BackColor = StatoUpGreen;
            StatusServer = true;
            tmrSuspend.Stop();


        }

        private void btnSospendi_Click(object sender, EventArgs e)
        {
            PanelStatus.BackColor = StatoSuspendYellow;
            StatusServer = false;
            tmrSuspend.Start();


        }

        private void btnRispristino_Click(object sender, EventArgs e)
        {
            tmrSuspend.Stop();
        }

        private void srlPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //In teoria qui riceve i dati dal client e legge il buffer
        {
            for (int i = 0; true/*i < srlPort1.ReadExisting().Length*/; i++)
            {
                if (srlPort1.ReadLine() == "" || srlPort1.ReadLine() == null)
                    break;
                else
                {
                    Array.Resize(ref arrInterrogazioni, arrInterrogazioni.Length + 1);
                    arrInterrogazioni[i] = srlPort1.ReadLine(); // Memorizzo ogni riga all'interno di ogni indice dell'array cosi è molto più semplice eseguire i risultati e fare il match (select from) con le singole righe
                }
            }

        }

        private void tmrSuspend_Tick(object sender, EventArgs e)
        {
            k++;
            //txtCronologia.Text = k.ToString();
            lblCountDown.Text = k.ToString();
            if (k == (120))
            {
                PanelStatus.BackColor = StatoDownRed;
                MessageBox.Show("Il server ha superato 2 min di pausa quindi è down", "Actenction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tmrSuspend.Stop();
            }
        }

        public static void ExecuteQuery()
        {
            string[] parametro;
            foreach(string inter in arrInterrogazioni)
            {
                parametro = inter.Split(' ');
                if(parametro[0] == "ISII")
                    

            }

        }

        public static void Filtro()
        {

        }
    }
}

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
        public static Myrs232c myRs232;
        public static string[] arrInterrogazioni = new string[0];
        private static int k = 121;
        private Database DbIsii = new Database("ISII");
        private Database DbTramello = new Database("Tramello");
        public static List<Database> ElencoDB;
        public static List<List<string>> Output = new List<List<string>>();


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
            myRs232.Open();
            lblCountDown.Text = "";
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            PanelStatus.BackColor = StatoUpGreen;
            StatusServer = true;
            tmrSuspend.Stop();
            //txtCronologia.Text =  myRs232.ReadExisting().ToString();
            tmrRicevi.Start();
        }

        private void btnSospendi_Click(object sender, EventArgs e)
        {
            PanelStatus.BackColor = StatoSuspendYellow;
            lblCountDown.Text = "120";
            StatusServer = false;
            tmrSuspend.Start();
            tmrRicevi.Stop();

        }

        private void btnRispristino_Click(object sender, EventArgs e)
        {
            tmrSuspend.Stop();
            tmrRicevi.Stop();
        }

        private void srlPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //In teoria qui riceve i dati dal client e legge il buffer
        {
            //for (int i = 0; true/*i < srlPort1.ReadExisting().Length*/; i++)
            //{
            //    //    if (srlPort1.ReadLine() == "" || srlPort1.ReadLine() == null)
            //    //        break;
            //    //    else
            //    //    {
            //    Array.Resize(ref arrInterrogazioni, arrInterrogazioni.Length + 1);
            //        arrInterrogazioni[i] = srlPort1.ReadLine(); // Memorizzo ogni riga all'interno di ogni indice dell'array cosi è molto più semplice eseguire i risultati e fare il match (select from) con le singole righe
            //                                                    //    }
            //}
            //txtCronologia.Text += myRs232.ReadExisting().ToString();


        }

        private void tmrSuspend_Tick(object sender, EventArgs e)
        {
            k--;
            //txtCronologia.Text = k.ToString();
            lblCountDown.Text = k.ToString();
            if (k == (0))
            {
                PanelStatus.BackColor = StatoDownRed;
                MessageBox.Show("Il server ha superato 2 min di pausa quindi è down", "Actenction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tmrSuspend.Stop();
            }
        }

        public static void ExecuteQuery()
        {
            string[] parametro;
            string[] selects;

            List<string> Elenco = new List<string>();
            foreach (string inter in arrInterrogazioni) // Scorrimento delle query
            {
                parametro = inter.Split(' ');

                if (parametro[0].ToUpper() == "USE")
                {

                    foreach (Database MyDB in ElencoDB)
                    {

                        if (parametro[1] == MyDB.NameDB) // Trovo il Database
                        {
                            if (parametro[2].ToUpper() == "SELECT")
                            {
                                #region OLD
                                //switch (parametro[3].ToUpper())
                                //{
                                //    case "NOME":
                                //        for (int j = 0; j < ElencoDB[i].Db_Allievi.Length - 1; j++)
                                //        {
                                //            string[] record = ElencoDB[i].Db_Allievi[j].Split(' ');


                                //             Elenco.Add(record[0]);
                                //            //myRs232.Write(nomi[0] + "\r\n");
                                //        }
                                //        break;
                                //    case "COGNOME":
                                //        for (int j = 0; j < ElencoDB[i].Db_Allievi.Length - 1; j++)
                                //        {
                                //            string[] record = ElencoDB[i].Db_Allievi[j].Split(' ');


                                //            Elenco.Add(record[0]);
                                //            //myRs232.Write(nomi[0] + "\r\n");
                                //        }
                                //        break;
                                //    case "NUMERO": break;

                                //}
                                #endregion

                                selects = parametro[3].Split(','); // Divido il select



                            }





                        }
                    }



                }
                //if(parametro[0] == "ISII")


            }

        }

        public static void Find()
        {

        }

        private void tmrRicevi_Tick(object sender, EventArgs e)
        {
            // Scorrere la lista con le query e sriverla
            if (myRs232.BytesToRead > 0)
            {

                string query = myRs232.ReadExisting().ToString();
                txtCronologia.Text += query + "\r\n" + "_________________" + "\r\n";
                Array.Resize(ref arrInterrogazioni, arrInterrogazioni.Length + 1);
                arrInterrogazioni[arrInterrogazioni.Length - 1] = query;

                ExecuteQuery();
            }

        }
    }
}

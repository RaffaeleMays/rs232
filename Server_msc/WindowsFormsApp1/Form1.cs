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
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class frmMainServer : Form
    {

        #region Colori status del server
        public Color StatoDownRed = Color.Red;
        public Color StatoUpGreen = Color.Green;
        public Color StatoSuspendYellow = Color.Yellow;
        #endregion

        #region Globals
        private static bool StatusServer;
        public static MyRs232c myRs232;
        public static List<string> elencoInterrogazioni;
        private static int countDown = 121;
        private Database dbIsii;
        private Database dbTramello;
        public static List<Database> elencoDB;
        //public static List<List<string>> Output = new List<List<string>>();
        #endregion

        public frmMainServer()
        {
            InitializeComponent();
        }

        private void frmMainServer_Load(object sender, EventArgs e)
        {
            myRs232 = new MyRs232c();
            elencoDB = new List<Database>();
            dbIsii = new Database("ISII");
            dbTramello = new Database("Tramello");
            elencoInterrogazioni = new List<string>();
            elencoDB.Add(dbIsii);
            elencoDB.Add(dbTramello);
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

        private void srlPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
            countDown--;
            //txtCronologia.Text = k.ToString();
            lblCountDown.Text = countDown.ToString();
            if (countDown == (0))
            {
                PanelStatus.BackColor = StatoDownRed;
                MessageBox.Show("Il server ha superato 2 min di pausa quindi è down", "Actenction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tmrSuspend.Stop();
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            string[] parametro;
            string[] selects;
            string use_Need;
            string from_Need;
            DataTable Output = new DataTable();

            parametro = query.Split(' ');
            if (parametro.Length == 6)
            {
                if (parametro[0].ToUpper() == "USE")
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
                        if (parametro[4].ToUpper() == "FROM")
                        {
                            foreach (Database MyDB in elencoDB)
                            {
                                use_Need = parametro[1];
                                from_Need = parametro[5];

                                if (use_Need == MyDB.NameDB) // Trovo il Database
                                {
                                    selects = parametro[3].Split(','); // Divido i campi della SELECT

                                    foreach (DataTable tab in MyDB.Tables) // Scorro le tabelle nel mio DB
                                    {
                                        if (tab.TableName.ToUpper() == from_Need.ToUpper()) // Trovo il nome della tabella
                                        {
                                            for (int i = 0; i < selects.Length; i++) // Scorro i campi della SELECT
                                            {
                                                int cont = 0;
                                                foreach (DataColumn attributo in tab.Columns)
                                                {
                                                    cont++;
                                                    if (attributo.ColumnName.ToUpper() == selects[i].ToUpper())
                                                    {
                                                        foreach (DataRow record in tab.Rows)
                                                            Output.Rows.Add(record[cont]);
                                                        if (Output.Rows.Count > 0)
                                                            Output.Columns.Add(attributo.ColumnName);
                                                    }
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                elencoInterrogazioni.Add(String.Join(" ", parametro));
            }
            return Output;
        }

        private void tmrRicevi_Tick(object sender, EventArgs e)
        {
            // Scorrere la lista con le query e scriverla
            if (myRs232.BytesToRead > 0)
            {
                string query = myRs232.ReadExisting().ToString();
                JsonConvert.SerializeObject(ExecuteQuery(query));
                foreach (string dato in elencoInterrogazioni)
                    txtCronologia.Text += dato + "\r\n";
            }

        }
    }
}

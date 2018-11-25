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
        //public static List<string> elencoInterrogazioni;
        private static int countDown;
        public static Database dbIsii;
        public static Database dbTramello;
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
            for (int i = 0; i < SerialPort.GetPortNames().Length; i++)
                cmbCOMPorts.Items.Add(SerialPort.GetPortNames()[i]);
            //myRs232.NewOpen();
            elencoDB = new List<Database>();
            dbIsii = new Database("ISII");
            dbTramello = new Database("Tramello");
            //elencoInterrogazioni = new List<string>();
            elencoDB.Add(dbIsii);
            elencoDB.Add(dbTramello);
            PnlStatus.BackColor = StatoDownRed;
            StatusServer = false;
            countDown = 10;

            

            lblCountDown.Text = "";
            tmrRicevi.Start();
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            PnlStatus.BackColor = StatoUpGreen;
            StatusServer = true;
            tmrSuspend.Stop();
            
        }

        private void btnSospendi_Click(object sender, EventArgs e)
        {
            PnlStatus.BackColor = StatoSuspendYellow;
            //lblCountDown.Text = countDown.ToString();
            StatusServer = false;
            tmrSuspend.Start();
            //tmrRicevi.Stop();
        }

        private void tmrSuspend_Tick(object sender, EventArgs e)
        {
            //txtCronologia.Text = k.ToString();
            lblCountDown.Text = countDown.ToString();
            countDown--;
            if (countDown == 0)
            {
                PnlStatus.BackColor = StatoDownRed;
                lblCountDown.Text = "";
                countDown = 120;
                MessageBox.Show("Il server ha superato 2 min di pausa quindi è down", "Actenction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                tmrSuspend.Stop();
            }
        }

        private void btnRispristino_Click(object sender, EventArgs e)
        {
            tmrSuspend.Stop();
            tmrRicevi.Start();
        }

        public Object ExecuteQuery(string query)
        {
            string[] parametro;
            string[] selects;
            string use_Need;
            string from_Need;
            string error;
            DataTable output = new DataTable();
            List<string> tupla;
            List<List<string>> tuple = new List<List<string>>();
            //string[,] error = new string[1, 2];
            //error[0, 0] = "Exception";



            if (query.ToUpper().Contains("USE") && query.ToUpper().Contains("SELECT") && query.ToUpper().Contains("FROM"))
            {
                parametro = query.Split(' ');
                //if (parametro[0].ToUpper() == "USE" && parametro[2].ToUpper() == "SELECT" & parametro[4].ToUpper() == "FROM")
                //{
                if (parametro.Length == 6)
                {
                    use_Need = parametro[1];
                    from_Need = parametro[5].Substring(0, parametro[5].IndexOf("\n"));

                    foreach (Database MyDB in elencoDB)
                    {
                        if (use_Need.ToUpper() == MyDB.NameDB.ToUpper()) // Trovo il Database
                        {
                            selects = parametro[3].Split(','); // Divido i campi della SELECT

                            foreach (DataTable tab in MyDB.Tables) // Scorro le tabelle nel mio DB
                            {
                                if (tab.TableName.ToUpper() == from_Need.ToUpper()) // Trovo il nome della tabella
                                {
                                    output.TableName = tab.TableName;
                                    for (int i = 0; i < selects.Length; i++) // Scorro i campi della SELECT
                                    {
                                        int cont = 0;
                                        foreach (DataColumn attributo in tab.Columns)
                                        {
                                            //tupla.Clear();
                                            tupla = new List<string>();

                                            if (attributo.ColumnName.ToUpper() == selects[i].ToUpper()) // Controllo se l'attributo è uguale al mio select
                                            {
                                                output.Columns.Add(attributo.ColumnName); // Aggiungo la colonna ad 'output'
                                                foreach (DataRow record in tab.Rows)
                                                {
                                                    tupla.Add(record.ItemArray[cont].ToString()); // Riempio il nuovo record

                                                }
                                                tuple.Add(tupla); // Aggiungo il record alla tabella
                                                break;
                                            }
                                            cont++;

                                        }
                                    }
                                    break;
                                }
                            }

                            // Algoritmo per riempire la tabella
                            if (tuple.Count > 0)
                            {
                                for (int y = 0; y < tuple[0].Count; y++)
                                {
                                    tupla = new List<string>();
                                    for (int x = 0; x < tuple.Count; x++)
                                    {
                                        tupla.Add(tuple[x][y]);

                                    }
                                    output.Rows.Add(tupla.ToArray());
                                }
                            }
                            break;
                        }
                    }
                }
                else
                {
                    //error[0, 1] = "Sintassi non corretta";
                    //return error;
                    error = "\"Sintassi non corretta\"";
                    return error;
                }
            }
            else
            {
                //error[0, 1] = "Necessarie la clausole 'USE', 'SELECT' e 'FROM'";
                //return error;
                error = "\"Necessarie la clausole 'USE', 'SELECT' e 'FROM'\"";
                return error;
            }

            //elencoInterrogazioni.Add(String.Join(" ", parametro));
            lblCronologia.Items.Add((lblCronologia.Items.Count + 1).ToString() + ") " + String.Join(" ", parametro));
            return output;
        }

        //private void ServerStatusManager(bool ONorOFF)
        //{
        //    StatusServer = ONorOFF;
        //    if (StatusServer)
        //    {
        //        PnlStatus.BackColor = Color.Green;
        //    }
        //    else
        //        PnlStatus.BackColor = Color.Red;
        //}

        private void tmrRicevi_Tick(object sender, EventArgs e)
        {
            if(myRs232.IsOpen)
            {
                if (myRs232.BytesToRead > 0)
                {
                    if (StatusServer == false)
                    {
                        myRs232.Write("\"Il server non e' al momento disponibile\"");
                        myRs232.DiscardInBuffer();
                    }
                    else
                    {
                        if (myRs232.BytesToRead > 0) // Se ho qualche richiesta la leggo
                        {
                            string query = myRs232.ReadExisting().ToString();
                            string a = JsonConvert.SerializeObject(ExecuteQuery(query));
                            myRs232.Write(a);
                            //txtCronologia.Clear();
                            //foreach (string dato in elencoInterrogazioni)
                            //    txtCronologia.Text += dato + "\r\n";
                        }
                    }
                }
            }
        }

        private void btnAvvia_MouseEnter(object sender, EventArgs e)
        {
            btnAvvia.BackColor = Color.LightGreen;
        }

        private void btnAvvia_MouseLeave(object sender, EventArgs e)
        {
            btnAvvia.BackColor = this.BackColor;
        }

        private void btnSospendi_MouseEnter(object sender, EventArgs e)
        {
            btnSospendi.BackColor = Color.LightYellow;
        }

        private void btnSospendi_MouseLeave(object sender, EventArgs e)
        {
            btnSospendi.BackColor = this.BackColor;
        }

        private void btnRispristino_MouseEnter(object sender, EventArgs e)
        {
            btnRispristino.BackColor = Color.CornflowerBlue;
        }

        private void btnRispristino_MouseLeave(object sender, EventArgs e)
        {
            btnRispristino.BackColor = this.BackColor;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (myRs232.PortName != cmbCOMPorts.Text)
            {
                rdbDown.Checked = true;
                myRs232.Close();
                try
                {
                    myRs232.NewOpen(cmbCOMPorts.Text);
                    if (myRs232.IsOpen)
                        rdbUp.Checked = true;
                }
                catch
                {
                    MessageBox.Show("Impossibile connettersi alla porta " + cmbCOMPorts.Text, "Actenction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnConnect_MouseEnter(object sender, EventArgs e)
        {
            btnConnect.BackColor = Color.LightPink;
        }

        private void btnConnect_MouseLeave(object sender, EventArgs e)
        {
            btnConnect.BackColor = this.BackColor;
        }
    }
}

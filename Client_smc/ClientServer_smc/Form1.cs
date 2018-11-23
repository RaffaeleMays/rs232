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
using System.Data.SqlClient;
using Newtonsoft.Json;


namespace ClientServer_smc
{
    public partial class frmMain : Form
    {
        MyRs232 myRs232;
        Object result;
        //DataTable resultA;
        //DataTable resultI;
        //public static bool tabA;
        //public static bool tabI;
        string query;

        public frmMain()
        {
            InitializeComponent();

        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            result = new Object();
            myRs232 = new MyRs232();
            myRs232.NewOpen();
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInsertQuery.Clear();

        }

        // Buffer di output
        private void btnQuery_Click(object sender, EventArgs e)
        {

            query = txtInsertQuery.Text;

            myRs232.WriteLine(query);

            //txtResult.Clear();
            lstQueryList.Items.Add((lstQueryList.Items.Count + 1).ToString() + ") " + query);
            tmrResult.Start();


            //myRs232.Write("ciao");
        }


        private void srlPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // QUI SI DESERIALIZZA (trasformare il json in una classe) IL MESSAGGIO RICEVUTO

            //object ritorno = JsonConvert.DeserializeObject(/*Inserire la stringa di tipo json vedi sopra es.queryJSON*/);
            //txtQuery.Text = (string)ritorno;
            

        }

        private void tmrResult_Tick(object sender, EventArgs e)
        {
            if (myRs232.BytesToRead > 0)
            {
                string inBuffer = myRs232.ReadExisting().ToString();
                //Visualizza nella tabella Result il Jason ricevuto

                try
                {
                    result = JsonConvert.DeserializeObject<DataTable>(inBuffer);
                    frmResult frm_Result = new frmResult();
                    frm_Result.SetTable((DataTable)result, query);
                    frm_Result.Show();
                }
                catch
                {
                    MessageBox.Show(inBuffer, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                

                //if (result.TableName.ToUpper() == "ALLIEVI")
                //    tabA = true;
                //else if (result.TableName.ToUpper() == "INSEGNANTI")
                //    tabI = true;
                //if(inBuffer.Contains("allievi") == true)
                //   {
                //    result = JsonConvert.DeserializeObject<DataTable>(inBuffer);
                //    tabA = true;

                //   }
                //else if(inBuffer.Contains("Insegnanti") == true)
                //{
                //    result = JsonConvert.DeserializeObject<DataTable>(inBuffer);
                //    tabI = true;
                //}

                //DataTable result = (DataTable)JsonConvert.DeserializeObject(inBuffer, (typeof(DataTable))); //oppure questo ma non so se funziona

                //frmTables.Collegamento(result, tabA, tabI); // invia il datattable all'altra form e inserisce le bool o di allievo o di insegnante cosi poi le distingue nel datagridview

            }
        }
    }
}

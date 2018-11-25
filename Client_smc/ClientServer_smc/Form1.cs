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
        #region Globals
        MyRs232 myRs232;
        Object result;
        string query;
        //bool connection;
        //DataTable resultA;
        //DataTable resultI;
        //public static bool tabA;
        //public static bool tabI;
        #endregion

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            result = new Object();
            //myRs232 = new MyRs232();
            //connection = false;
            for (int i = 0; i < SerialPort.GetPortNames().Length; i++)
                cmbCOMPorts.Items.Add(SerialPort.GetPortNames()[i]);
            rdbDown.Checked = true;
            //myRs232.NewOpen();
            grpQuery.Enabled = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInsertQuery.Clear();

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (myRs232.CtsHolding == true)
            {
                query = txtInsertQuery.Text;
                //if (connection)
                //{
                myRs232.WriteLine(query);
                tmrResult.Start();
            }
            else
                MessageBox.Show("Il server non e' al momento disponibile", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //MessageBox.Show("Connettersi prima ad una porta seriale", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //txtResult.Clear();
                //lstQueryList.Items.Add((lstQueryList.Items.Count + 1).ToString() + ") " + query);
                //myRs232.Write("ciao");
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
                    lstQueryList.Items.Add((lstQueryList.Items.Count + 1).ToString() + ") " + query);
                    frmResult frm_Result = new frmResult();
                    frm_Result.SetTable((DataTable)result, query);
                    frm_Result.Show();
                }
                catch
                {
                    MessageBox.Show(inBuffer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //if (myRs232.PortName != cmbCOMPorts.Text)
            //{
            try
            {
                myRs232.Close();
            }
            catch { }
            rdbDown.Checked = true;

            try
            {
                myRs232 = new MyRs232(cmbCOMPorts.Text);
                myRs232.NewOpen();
                if (myRs232.IsOpen)
                {
                    grpQuery.Enabled = true;
                    rdbUp.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Impossibile connettersi alla porta " + cmbCOMPorts.Text, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpQuery.Enabled = false;
            }
            //}
        }
    }
}

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
        DataTable result;

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            result = new DataTable();
            myRs232 = new MyRs232();
            myRs232.Open();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuery.Clear();

        }

        // Buffer di output
        private void btnQuery_Click(object sender, EventArgs e)
        {

            string query = txtQuery.Text;

            myRs232.WriteLine(query);

            txtResult.Clear();
            tmrResult.Start();
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
                try
                {
                    result = JsonConvert.DeserializeObject<DataTable>(inBuffer);
                }
                catch
                {                    
                    MessageBox.Show(inBuffer, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

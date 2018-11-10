﻿using System;
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
        private MyRs232 myRs232;

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            myRs232 = new MyRs232();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuery.Clear();


        }

        // Buffer di output
        private void btnQuery_Click(object sender, EventArgs e)
        {

            string query = txtQuery.Text;
            // QUI SOTTO VA SERIALIZZATO (trasformare una classe in json) IL MESSAGGIO IN JSON
            //query = JsonConvert.SerializeObject();
            string queryJASON = JsonConvert.SerializeObject(query);


            //myRs232.Write(result);



            //myRs232.DtrEnable = true; non importante
        }


        private void srlPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // QUI SI DESERIALIZZA (trasformare il json in una classe) IL MESSAGGIO RICEVUTO
            
            //object ritorno = JsonConvert.DeserializeObject(/*Inserire la stringa di tipo json vedi sopra es.queryJSON*/);
            //txtQuery.Text = (string)ritorno;

        }
        
    }
}

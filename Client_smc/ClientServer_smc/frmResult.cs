using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServer_smc
{
    public partial class frmResult : Form
    {
        DataTable myTable;
        public frmResult()
        {
            InitializeComponent();

        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            myTable = new DataTable();
            SetLabel_Middle(lblQuery, this);
        }

        internal void SetTable(DataTable table, string query)
        {
            //myTable = table;

            lblQuery.Text = query;
            
            SetLabel_Middle(lblQuery, this);
            dgvQuery.DataSource = table;


            //for (int i = 0; i < dgvQuery.Rows.Count; i++)
            //    dgvQuery.Rows[0].Cells[0].Value = i.ToString();
            

            //foreach (DataColumn col in myTable.Columns)
            //{
            //    dgvQuery.Columns.Add("dgc" + col.ColumnName, col.ColumnName);
            //}

            //foreach (DataRow row in myTable.Rows)
            //{                
            //    dgvQuery.Rows.Add(row.ItemArray);
            //}
        }

        private static void SetLabel_Middle(Label myLabel, frmResult myForm)
        {
            myLabel.Location = new Point((myForm.Size.Width / 2) - (myLabel.Size.Width / 2), myLabel.Location.Y);
        }
    }
}

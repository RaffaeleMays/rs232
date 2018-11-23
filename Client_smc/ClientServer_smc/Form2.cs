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
    public partial class frmTables : Form
    {
        public static DataTable table = new DataTable();
        public static bool tabA;
        public static bool tabI;

        public frmTables()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (tabA == true)
            {
                this.dgvAllievi.DataSource = table;

            }
            else if (tabI == true)
            {
                this.dgvInsegnanti.DataSource = table;

            }



        }
        public static void Collegamento(DataTable result, bool Allievi, bool Insegnanti)
        {
            //table = result;
            //if (Allievi == true)
            //    tabA = true;
            //else if (Insegnanti == true)
            //    tabI = true;
            //frmTables.ActiveForm.Show();

        }
    }
}

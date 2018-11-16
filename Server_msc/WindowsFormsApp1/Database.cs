using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Database
    {
        //Dichiarazione
        //private string[] tab_Insegnanti;
        //private string[] tab_Allievi;
        private static string nameDB;
        private static List<DataTable> tables;



        public string NameDB { get => nameDB; set => nameDB = value; }
        //public string[] Tab_Insegnanti { get => tab_Insegnanti; set => tab_Insegnanti = value; }
        //public string[] Tab_Allievi { get => tab_Allievi; set => tab_Allievi = value; }
        public List<DataTable> Tables { get => tables; set => tables = value; }

        //Inizializzazione
        public Database(string name)
        {
            //Tab_Insegnanti = new string[3];
            //Tab_Allievi = new string[3];

            /*//Array.Resize(Db_Insegnanti, Db_Insegnanti.Length + 3);
            Db_Insegnanti[0] = "Mario Rossi 3339065819";
            Db_Insegnanti[1] = "Davide Verdi 3349069719";
            Db_Insegnanti[2] = "Matteo Neri 3339375819";

            //Array.Resize(Db_Allievi, Db_Allievi.Length + 3);
            Db_Allievi[0] = "Mattia Grigi 3329045579";
            Db_Allievi[1] = "Gandolfo Blu 3324966819";
            Db_Allievi[2] = "Elia Bianchi 3336368889";

            NameDB = name;*/

            // *******************************

            Tables = new List<DataTable>();

            // Allievi
            DataTable tabA = new DataTable("Allievi");
            tabA.Columns.Add("Nome", typeof(string));
            tabA.Columns.Add("Cognome", typeof(string));
            tabA.Columns.Add("Numero", typeof(string));

            tabA.Rows.Add("Mario", "Rossi", "3339065819");
            tabA.Rows.Add("Davide", "Verdi", "3349069719");
            tabA.Rows.Add("Matteo", "Neri", "3339375819");


            // Insegnanti
            DataTable tabI = new DataTable("Insegnanti");
            tabI.Columns.Add("Nome", typeof(string));
            tabI.Columns.Add("Cognome", typeof(string));
            tabI.Columns.Add("Numero", typeof(string));

            tabI.Rows.Add("Mattia", "Grigi", "3329045579");
            tabI.Rows.Add("Gandolfo", "Blu", "3324966819");
            tabI.Rows.Add("Elia", "Bianchi", "3336368889");            

            Tables.Add(tabA);
            Tables.Add(tabI);

            NameDB = name;

            #region Comments
            //db_Insegnanti = new string[,] { };
            //db_Allievi = new string[,] { };

            //Array.Resize(ref db_Insegnanti, db_Insegnanti.Length + 3);
            //db_Insegnanti[0, 0] = "Mario";
            //db_Insegnanti[0, 1] = "Rossi";
            //db_Insegnanti[0, 2] = "3339065819";

            //db_Insegnanti[1, 0] = "Davide";
            //db_Insegnanti[1, 1] = "Verdi";
            //db_Insegnanti[1, 2] = "3349069719";



            //db_Insegnanti[2,0] = "Matteo";
            //db_Insegnanti[2,1] = "Neri";
            //db_Insegnanti[2,2] = "3339375819";

            ////Array.Resize(ref db_Allievi, db_Allievi.Length + 3);
            ////db_Allievi[0] = " Mattia Grigi 3329045579";
            ////db_Allievi[1] = " Gandolfo Blu 3324966819";
            ////db_Allievi[2] = " Elia Bianchi 3336368889";

            //db_Allievi[0, 0] = "Mattia";
            //db_Allievi[0, 1] = "Grigi";
            //db_Allievi[0, 2] = "3329045579";

            //db_Allievi[1, 0] = "Gandolfo";
            //db_Allievi[1, 1] = "Blu";
            //db_Allievi[1, 2] = "3324966819"; 

            //db_Allievi[2, 0] = "Elia";
            //db_Allievi[2, 1] = "Bianchi";
            //db_Allievi[2, 2] = "3336368889";
            #endregion
        }

        public void Insert_Insegnante(string nome, string cognome, string numero)
        {
            //Array.Resize(ref db_Insegnanti, Db_Insegnanti.Length + 1);
            //Db_Insegnanti[db_Insegnanti.Length - 1] = nome + " " + cognome + " " + numero;
            

            foreach(DataTable Tab in Tables)
            {
                if (Tab.TableName == "Insegnanti")
                    Tab.Rows.Add(nome, cognome, numero);
            }

            
        }

        public void Insert_Allievo(string nome, string cognome, string numero)
        {
            //Array.Resize(ref db_Insegnanti, Db_Insegnanti.Length + 1);
            //Db_Insegnanti[db_Insegnanti.Length - 1] = nome + " " + cognome + " " + numero;

            foreach (DataTable Tab in Tables)
            {
                if (Tab.TableName == "Allievi")
                    Tab.Rows.Add(nome, cognome, numero);
            }


        }

    }
}

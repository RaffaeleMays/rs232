using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Database
    {
        //Dichiarazione
        private  string[] db_Insegnanti;
        private  string[] db_Allievi;
        private string nameDB;
        

        public string NameDB { get => nameDB; set => nameDB = value; }
        public string[] Db_Insegnanti { get => db_Insegnanti; set => db_Insegnanti = value; }
        public string[] Db_Allievi { get => db_Allievi; set => db_Allievi = value; }

        //Inizializzazione
        public Database(string name)
        {
            Db_Insegnanti = new string[3];
            Db_Allievi = new string[3];

            //Array.Resize(Db_Insegnanti, Db_Insegnanti.Length + 3);
            Db_Insegnanti[0] = " Mario Rossi 3339065819";
            Db_Insegnanti[1] = " Davide Verdi 3349069719";
            Db_Insegnanti[2] = " Matteo Neri 3339375819";

            //Array.Resize(Db_Allievi, Db_Allievi.Length + 3);
            Db_Allievi[0] = " Mattia Grigi 3329045579";
            Db_Allievi[1] = " Gandolfo Blu 3324966819";
            Db_Allievi[2] = " Elia Bianchi 3336368889";

            NameDB = name;

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
        }

        public void Insert_Insegnante(string nome, string cognome, string numero)
        {
            Array.Resize(ref db_Insegnanti, Db_Insegnanti.Length + 1);
            Db_Insegnanti[db_Insegnanti.Length - 1] = nome + " " + cognome + " " + numero;

        }

        public void Insert_Allievo(string nome, string cognome, string numero)
        {
            Array.Resize(ref db_Insegnanti, Db_Insegnanti.Length + 1);
            Db_Insegnanti[db_Insegnanti.Length - 1] = nome + " " + cognome + " " + numero;

        }

    }
}

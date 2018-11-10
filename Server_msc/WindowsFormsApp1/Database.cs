using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class Database {
        //Dichiarazione
        private static string[] db_Insegnanti;
        private static string[] db_Allievi;
        private static string nameDB;

        //Inizializzazione
        public Database(string name) {
            db_Insegnanti = new string[] { };
            db_Allievi = new string[] { };

            Array.Resize(ref db_Insegnanti, db_Insegnanti.Length + 3);
            db_Insegnanti[0] = " Mario Rossi 3339065819";
            db_Insegnanti[1] = " Davide Verdi 3349069719";
            db_Insegnanti[2] = " Matteo Neri 3339375819";

            Array.Resize(ref db_Allievi, db_Allievi.Length + 3);
            db_Allievi[0] = " Mattia Grigi 3329045579";
            db_Allievi[1] = " Gandolfo Blu 3324966819";
            db_Allievi[2] = " Elia Bianchi 3336368889";
        }

        public void Insert_Insegnante(string nome, string cognome, string numero) {
            Array.Resize(ref db_Insegnanti, db_Insegnanti.Length + 1);
            db_Insegnanti[db_Insegnanti.Length - 1] = nome + " " + cognome + " " + numero;

        }

        public void Insert_Allievo(string nome, string cognome, string numero) {
            Array.Resize(ref db_Insegnanti, db_Insegnanti.Length + 1);
            db_Insegnanti[db_Insegnanti.Length - 1] = nome + " " + cognome + " " + numero;

        }

    }
}

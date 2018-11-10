using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ISII
    {
        //Dichiarazione
        public static string[] DB_InsegnantiISII = new string[] { };
        public static string[] DB_AllieviISII = new string[] { };

        //Inizializzazione
        public ISII()
        {
            Array.Resize(ref DB_InsegnantiISII, DB_InsegnantiISII.Length + 3);
            DB_InsegnantiISII[0] = " Mario Rossi 3339065819";
            DB_InsegnantiISII[1] = " Davide Verdi 3349069719";
            DB_InsegnantiISII[2] = " Matteo Neri 3339375819";

            Array.Resize(ref DB_AllieviISII, DB_AllieviISII.Length + 3);
            DB_AllieviISII[0] = " Mattia Grigi 3329045579";
            DB_AllieviISII[1] = " Gandolfo Blu 3324966819";
            DB_AllieviISII[2] = " Elia Bianchi 3336368889";
        }
       
        //
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FileHelpers;

namespace Inventway
{
   [DelimitedRecord(";")]
    public class DBInventory
    {
        public int Numero;

        public string DateInventaire;

        public string CodeProvisoire;

        public string Codedefinitif;


        public string  dateFret;

        public string designation;

        public string Marque;


        public string Type;

        public string Serie;

        public string Structure;

        public string EmplacementPricnipale;

        public string EmplacementSecondaire;


        public string Site;

        public string EtatPhysique;
        
        public string Obs;



    }


}

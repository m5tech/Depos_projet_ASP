using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exemple_mvc.Models
{
    public class Produit
    {
        public Produit(int iD, string nAME, decimal pRICE, string dESCRIPTION)
        {
            ID = iD;
            NAME = nAME;
            PRICE = pRICE;
            DESCRIPTION = dESCRIPTION;
        }

        public int ID { get; set; }
        public string NAME { get; set; }
        public decimal PRICE { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
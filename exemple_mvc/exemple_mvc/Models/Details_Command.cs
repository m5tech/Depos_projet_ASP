//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exemple_mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Details_Command
    {
        public int ID_DC { get; set; }
        public Nullable<int> ID_CMD { get; set; }
        public Nullable<int> ID_PR { get; set; }
        public Nullable<int> QUANTITY { get; set; }
        public Nullable<System.DateTime> DATE_CMD { get; set; }
    
        public virtual commande commande { get; set; }
        public virtual produit produit { get; set; }
    }
}
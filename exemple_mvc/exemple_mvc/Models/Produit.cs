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
    
    public partial class produit
    {
        public int ID { get; set; }
        public string NAME_PRODUIT { get; set; }
        public Nullable<decimal> PRIX { get; set; }
        public string DESCRIPTION { get; set; }
        public string IMAGE { get; set; }
        public string TYPE_PRODUIT { get; set; }
    }
}

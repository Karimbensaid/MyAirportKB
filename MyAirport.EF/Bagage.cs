using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KB.MyAirport.EF
{
    public class Bagage
    {

        
        
        
        
        
        
        // <summary>
        /// Clé primaire de ce bagage
        /// </summary>
        [Key]
        public int BagageID { get; set; }
        /// <summary>
        /// Identifiant du vol correspondant à ce bagage
        /// </summary>
        public int? VolID { get; set; }
        public virtual Vol? Vol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CodeIata { get; set; }
        /// <summary>
        /// Date de création du bagage
        /// </summary>
        public DateTime? DateCreation{ get; set; }
        /// <summary>
        /// Classe du bagage
        /// </summary>
        public string Classe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Boolean? Prioritaire { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ssur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Escale { get; set; }

        public Bagage()
        {
        }
    }
}

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KB.MyAirport.EF
{
    public class Vol
    {
        public Vol()
        {
        }

        /// <summary>
        /// Clé primaire du Vol
        /// </summary>
        [Key]
        public int VoldID { get; set; }
        /// <summary>
        /// Compagnie pour ce vol
        /// </summary>
        public string Cie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Dhc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Pkg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Imm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short Pax { get; set; }
        /// <summary>
        /// Destination du vol
        /// </summary>
        public string Des { get; set; }
        /// <summary>
        /// Liste des bagages de ce vol
        /// </summary>
        public virtual ICollection<Bagage> Bagages { get; set; }

        /// <summary>
        /// Constructeur de la classe Vol
        /// </summary>
        /// <param name="cIE"></param>
        /// <param name="lIG"></param>
        /// <param name="dHC"></param>
        /// <param name="pKG"></param>
        /// <param name="iMM"></param>
        /// <param name="pAX"></param>
        /// <param name="dES"></param>
        public Vol(string cIE, string lIG, DateTime dHC, string pKG, string iMM, short pAX, string dES)
        {
            Cie = cIE;
            Lig = lIG ?? throw new ArgumentNullException(nameof(lIG));
            Dhc = dHC;
            Pkg = pKG ?? throw new ArgumentNullException(nameof(pKG));
            Imm = iMM ?? throw new ArgumentNullException(nameof(iMM));
            Pax = pAX;
            Des = dES ?? throw new ArgumentNullException(nameof(dES));
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}

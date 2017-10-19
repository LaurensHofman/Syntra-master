using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// This is the entity of a chamber
    /// </summary>
    public class Chamber : BaseEntity
    {
        /// <summary>
        /// Gets/Sets the chamber type
        /// </summary>
        public ChamberType Type { get; set; }


        // _variabele (_prize) ;  Property (Prize)
        
        private decimal? _price;

        /// <summary>
        /// Gets/Sets the price of the chamber
        /// When the price has no value or is equal or lower to 0
        /// then it takes the default price, defined in the ChamberType
        /// </summary>
        public decimal Price
        {
            get
            {
                // .HasValue kan enkel werken als je de _prize nullable gemaakt hebt ("decimal?")
                // als de prijs geen waarde heeft OF de prijs <= 0  THEN 
                if(!_price.HasValue || _price <= 0)
                {
                    _price = Type.DefaultPrice;
                }

                return _price.Value;
            }

            set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Gets/Sets the capacity of the chamber
        /// </summary>
        public uint Capacity { get; set; }

        //ctor TAB TAB
        public Chamber() : base ()
        {
            Capacity = 1;

        }
    }
}

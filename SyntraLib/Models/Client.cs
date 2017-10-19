using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// This is the entity of a client
    /// </summary>
    //Verstoppen summaries CTRL M O
    public class Client : BaseEntity
    {
        /// <summary>
        /// Gets/Sets the first name of the client
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets/Sets the last name of the client
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets/Sets the birthdate of the client
        /// </summary>
        public DateTime BirthDate { get; set; }


        /// <summary>
        /// Gets/Sets the gender of the client, according to ISO-norms
        /// </summary>
        //geslacht volgens ISO normen (klasse Gender.cs)
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets/Sets the address of the client
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets/Sets the contact information of the client
        /// </summary>
        public Contactrecord ContactRecord { get; set; }









        //bedrijf en medewerker is meer op meer: |person| 1..*  ----  0..* |company|









    }
}

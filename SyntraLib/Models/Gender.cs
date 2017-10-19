using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// This is the enumeration to represent the human genders (ISO/IEC 5218)
    /// </summary>
    // public enumeration, zeker omdat het met ISO vastgelegd is
    public enum Gender
    {
        //als je geen enters overal wilt zetten, wacht met enters zetten ("Unknown=0") en dan CTRL K D
        Unknown = 0,
        Male = 1,
        Female = 2,
        NotApplicable = 9

    }
}

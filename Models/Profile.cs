using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Kuwadro.Models
{
    public class Profile
    {
        public ApplicationUser User { get; set; }
        public List<Art> ArtList { get; set; }
    }
}

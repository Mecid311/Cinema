using CinemaPro.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPro.Domain.ViewModel
{
    public class ExtraViewModel
    {
        public int Movieid { get; set; }
        public List<Extra> Extras { get; set; }
    }
}

using CinemaPro.Domain.Entity;
using System.Collections.Generic;

namespace CinemaPro.Domain.ViewModel
{
    public class HomeViewModel
    {
        public List<Moviedetail> MovieTit { get; set; }
        //public List<Mcat> MovieUpcome { get; set; }

        public List<Moviedetail> MovieUpcome { get; set; }

        public List<Moviedetail> MovieRelesed { get; set; }

        public List<Mcat> Mcats { get; set; }

        public List<Category> Categories { get; set; }

        public Moviedetail Movietrailer { get; set; }
        public List<Mcast> Mcasts { get; set; }

        public List<Cast> Casts { get; set; }

        public List<BtheS> BtheS { get; set; }


        public List<Partner> Partner { get; set; }



        public List<Mformat> Mformats { get; set; }


    }
}

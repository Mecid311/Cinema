using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaPro.Domain.Entity
{
    public class Moviedetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }

        public string Trailer { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public string ImageTemp { get; set; }

        public string TitleImage { get; set; }
        [NotMapped]
        public string TitleImageTemp { get; set; }

        public string Price { get; set; }

        public string Desc { get; set; }

        public string Country { get; set; }

        public string Time { get; set; }

        public string Agelimit { get; set; }

        public string Subtitles { get; set; }

        public int LanguageId { get; set; }

        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }

        public virtual Language Language { get; set; }

        public virtual ICollection<BtheS> BtheSes { get; set; }


        public virtual ICollection<Mcat> Mcats { get; set; }

        public virtual ICollection<Mformat> Mformats { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

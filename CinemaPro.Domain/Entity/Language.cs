using System.Collections.Generic;

namespace CinemaPro.Domain.Entity
{
    public class Language
    {
        public int Id { get; set; }

        public string Languages { get; set; }

        public virtual ICollection<Moviedetail> Moviedetails { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaPro.Domain.Entity
{
    public class BtheS
    {
        public int Id { get; set; }

        public string Video_Photo { get; set; }

        [NotMapped]
        public string ImagePathTemp { get; set; }

        public int MoviedetailId { get; set; }

        public virtual Moviedetail Moviedetail { get; set; }
    }
}

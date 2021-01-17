namespace CinemaPro.Domain.Entity
{
    public class Mcat
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public int MoviedetailId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Moviedetail Moviedetail { get; set; }
    }
}

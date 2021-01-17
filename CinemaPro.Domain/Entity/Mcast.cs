namespace CinemaPro.Domain.Entity
{
    public class Mcast
    {
        public int Id { get; set; }

        public int MoviedetailId { get; set; }

        public int CastId { get; set; }

        public virtual Moviedetail Moviedetail { get; set; }

        public virtual Cast Cast { get; set; }
    }
}

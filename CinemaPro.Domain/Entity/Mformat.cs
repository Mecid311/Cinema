namespace CinemaPro.Domain.Entity
{
    public class Mformat
    {
        public int Id { get; set; }
        public int MoviedetailId { get; set; }
        public int FormatId { get; set; }

        public Format Format { get; set; }
        public Moviedetail Moviedetail { get; set; }
    }
}

namespace CinemaPro.Domain.Entity
{
    public class Ticket
    {
        public int Id { get; set; }
        //public string FullName { get; set; }
        public string Totalamount { get; set; }

        public string Clientcode { get; set; }
        public int ExtraId { get; set; }

        public int MoviedetailId { get; set; }

        public int SeatId { get; set; }

        public virtual Extra Extra { get; set; }
        public virtual Moviedetail Moviedetail { get; set; }
        public virtual Seat Seat { get; set; }




    }
}

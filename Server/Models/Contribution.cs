namespace Server.Models
{
    public class Contribution
    {
        public int Id { get; set; }
        public DateTime ContributionDate { get; set; }
        public string ContributionForm { get; set; }
        public int Value { get; set; }

        public Member Member { get; set; }
    }
}

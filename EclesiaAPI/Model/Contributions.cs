namespace EclesiaAPI.Model
{
    public class Contributions
    {
        public int Id { get; set; }
        public DateTime ContributionDate { get; set; } 
        public string ContributionForm { get; set; }
        public int Value { get; set; }
    }
}

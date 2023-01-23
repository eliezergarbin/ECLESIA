namespace EclesiaAPI.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
        public string Affiliation { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public string baptism { get; set; }
        public string Receipt { get; set; }
        public int CEP { get; set; }
        public string UF { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }

        public List<Contribution> Contributions { get; set; }
        public Position Position { get; set; }

    }
}

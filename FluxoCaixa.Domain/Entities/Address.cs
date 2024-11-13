namespace FluxoCaixa.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Status { get; set; }
        public string UserIncluded { get; set; }
        public DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public ICollection<Collaborator>? Collaborators { get; set; }

        public Address()
        {
        }

        public Address(string street, string cEP, string city, string state, bool status, string userIncluded, DateTime dateIncluded)
        {
            Street = street;
            CEP = cEP;
            City = city;
            State = state;
            Status = status;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
        }
    }
}

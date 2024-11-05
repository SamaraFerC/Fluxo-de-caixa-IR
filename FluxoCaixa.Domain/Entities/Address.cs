namespace FluxoCaixa.Domain.Entities
{
    public class Address
    {
        public required int Id { get; set; }
        public required string Street { get; set; }
        public required string CEP { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required bool Status { get; set; }
        public required string UserIncluded { get; set; }
        public required DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public ICollection<Collaborator> Collaborators { get; set; }

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

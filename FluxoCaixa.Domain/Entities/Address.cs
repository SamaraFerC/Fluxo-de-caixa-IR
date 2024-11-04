namespace FluxoCaixa.Domain.Entities
{
    public class Address
    {
        public required int Id { get; set; }
        public required string CEP { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required bool Status { get; set; }
        public string UserIncluded { get; set; }
        public required DateTime DateIncluded { get; set; }
        public string UserChange { get; set; }
        public DateTime? DateChange { get; set; }

        public ICollection<Collaborator> Collaborators { get; set; }

        public Address()
        {

        }

        public Address(string cEP, string city, string state)
        {
            CEP = cEP;
            City = city;
            State = state;
        }
    }
}

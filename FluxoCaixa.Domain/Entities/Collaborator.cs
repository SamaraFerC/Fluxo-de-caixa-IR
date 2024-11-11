namespace FluxoCaixa.Domain.Entities
{
    public class Collaborator
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? DateBirth { get; set; }
        public string UserIncluded { get; set; }
        public DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
        public bool Status { get; set; }

        public int AddressID { get; set; }
        public int CollaboratorTypeID { get; set; }

        public CollaboratorTypes CollaboratorType { get; set; }
        public Address Address { get; set; }

        public Collaborator() { }

        public Collaborator(int id, string fullName, bool status, DateTime? dateBirth, string userIncluded, DateTime dateIncluded, int addressID, int collaboratorTypeID)
        {
            Id = id;
            FullName = fullName;
            Status = status;
            DateBirth = dateBirth;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
            AddressID = addressID;
            CollaboratorTypeID = collaboratorTypeID;
        }
    }
}
namespace FluxoCaixa.Domain.Entities
{
    public class Collaborator
    {
        public required int Id { get; set; }
        public required string FullName { get; set; }
        public DateTime? DateBirth { get; set; }
        public required string UserIncluded { get; set; }
        public DateTime DateIncluded { get; set; }      
        public string? UserChange { get; set; }
        public DateTime? DateChange { get; set; }
        public required bool Status { get; set; }

        public required int AddressID { get; set; }
        public required int TypeCollaboratorID { get; set; }

        public required TypeCollaborator TypeCollaborator { get; set; }
        public required Address Address { get; set; }

        public Collaborator() { }

        public Collaborator(int id, string fullName, bool status, DateTime? dateBirth, string userIncluded, DateTime dateIncluded, int addressID, int typeCollaboratorID)
        {
            Id = id;
            FullName = fullName;
            Status = status;
            DateBirth = dateBirth;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
            AddressID = addressID;
            TypeCollaboratorID = typeCollaboratorID;
        }
    }
}
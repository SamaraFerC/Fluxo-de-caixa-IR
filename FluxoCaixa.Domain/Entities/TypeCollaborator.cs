namespace FluxoCaixa.Domain.Entities
{
    public class TypeCollaborator
    {
        public required int Id { get; set; }
        public required string Description { get; set; }
        public required bool Status { get; set; } 
        public required string UserIncluded { get; set; }
        public required DateTime DateIncluded { get; set; }
        public string? UserChange { get; set; }
        public DateTime? DateChange { get; set; }

        public ICollection<Collaborator>? Collaborators { get; set; }

        public TypeCollaborator()
        {

        }

        public TypeCollaborator(int id, string description, bool status, string userIncluded, DateTime dateIncluded)
        {
            Id = id;
            Description = description;
            Status = status;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
        }
    }
}
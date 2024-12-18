﻿namespace FluxoCaixa.Domain.Entities
{
    public class CollaboratorTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string UserIncluded { get; set; }
        public DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public ICollection<Collaborator> Collaborators { get; set; }

        public CollaboratorTypes()
        {

        }

        public CollaboratorTypes(int id, string code, string description, bool status, string userIncluded, DateTime dateIncluded)
        {
            Id = id;
            Name = code;
            Description = description;
            Status = status;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
        }
    }
}
using System.ComponentModel.DataAnnotations;
namespace SFinanceiro.ModelData.Entities
{
    public class Collaborator
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        public bool Status { get; set; }

        public DateTime? DateBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string UserIncluded { get; set; }

        [Required]
        public DateTime DateIncluded { get; set; }

        [StringLength(50)]
        public string UserChange { get; set; }

        public DateTime? DateChange{ get; set; }

        public int AddressID { get; set; }
       
        public int TypeCollaboratorID { get; set; }
        
        public TypeCollaborator TypeCollaborator { get; set; }

        public Address Address { get; set; }

        public Collaborator() { }

        public Collaborator(int id, string fullName, DateTime? dateBirth, bool status, string userIncluded, DateTime dateIncluded)
        {
            Id = id;
            FullName = fullName;
            DateBirth = dateBirth;
            Status = status;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
        }
    }
}
namespace FluxoCaixa.Domain.Entities
{
    public class FlowType
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required bool Status { get; set; } 
        public required string UserIncluded { get; set; }
        public required DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public ICollection<CashFlow>? CashFlow { get; set; }

        public FlowType()
        {

        }

        public FlowType(int id,string code, string description, bool status, string userIncluded, DateTime dateIncluded)
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
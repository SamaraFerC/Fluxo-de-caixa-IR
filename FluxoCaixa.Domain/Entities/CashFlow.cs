namespace FluxoCaixa.Domain.Entities
{
    public class CashFlow
    {
        public int Id { get; set; }
        public int FlowTypeId { get; set; }
        public int ActivityId { get; set; }
        public int CollaboratorId { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal Value { get; set; }
        public bool Status { get; set; }
        public string UserIncluded { get; set; }
        public DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public required Activity Activity { get; set; }
        public required Collaborator Collaborator { get; set; }
        public required FlowType FlowType { get; set; }
        public required PaymentType PaymentType { get; set; }

        public CashFlow()
        {

        }

        public CashFlow(int flowTypeId, int activityId, int collaboratorId, int paymentTypeId, decimal value, bool status, string userIncluded, DateTime dateIncluded)
        {
            FlowTypeId = flowTypeId;
            ActivityId = activityId;
            CollaboratorId = collaboratorId;
            PaymentTypeId = paymentTypeId;
            Value = value;
            Status = status;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
        }
    }
}

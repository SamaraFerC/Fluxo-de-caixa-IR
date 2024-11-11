namespace FluxoCaixa.Domain.Entities
{
    public class CashFlow
    {
        public required int Id { get; set; }
        public required int FlowTypeId { get; set; }
        public required int ActivityId { get; set; }
        public required int CollaboratorId { get; set; }
        public required int PaymentTypeId { get; set; }
        public required decimal Value { get; set; }
        public required bool Status { get; set; }
        public required string UserIncluded { get; set; }
        public required DateTime DateIncluded { get; set; }
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

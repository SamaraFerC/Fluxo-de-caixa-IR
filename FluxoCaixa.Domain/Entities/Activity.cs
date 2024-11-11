namespace FluxoCaixa.Domain.Entities
{
    public class Activity
    {
        public required int Id { get; set; }
        public  string Name { get; set; }
        public  string Description { get; set; }
        public  bool Status { get; set; }
        public  string UserIncluded { get; set; }
        public  DateTime DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public Activity()
        {

        }

        public Activity(string title, string description, bool status, string userIncluded, DateTime dateIncluded)
        {
            Name = title;
            Description = description;
            Status = status;
            UserIncluded = userIncluded;
            DateIncluded = dateIncluded;
        }
    }
}

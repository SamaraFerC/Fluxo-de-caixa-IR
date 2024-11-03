namespace SFinanceiro.ModelData.Entities
{
    public class Address
    {
        public string AddressID { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string State { get; set; }

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

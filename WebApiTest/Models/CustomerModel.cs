namespace WebApiTest.Models
{
    public class CustomerModel
    {
        public CustomerModel(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; private set; }
        public string Address { get; private set; } 
    }
}
namespace CoffeeStore.Model
{
    public class Country
    {
        public Country(string countryName)
        {
            this.Name = countryName;
        }

        public string Name { get; set; }
    }
}
namespace Syntra.Models
{
    public class Country : BaseEntity
    {

        public string Name { get; set; }

        public string ISO { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }

        public Country() : base()
        {
            IsActive = true;
            IsDefault = false;
        }



        //optionele parameters, bijvoorbeeld: Country c = new Country ("België", "BE", isDefault: true); dan moet
        // volgorde niet correct zijn volgens onderstaande lijn

        public Country(string name, string iso, bool isActive = true, bool isDefault = false)
        {
            this.Name = name;
            this.ISO = iso;
            this.IsActive = isActive;
            this.IsDefault = isDefault;

        }











    }
}
namespace DressStore.Models
{
    public class Dress
    {
        protected decimal _discount = 0;

      
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
       // public string Type { get; set; }
        public Company Company { get; set; }

        public Dress(int id,string name,decimal price,Company company)
        {
            Id = id;
            Name = name;
            Price = price;
            Company = company;
        }

        public Dress(decimal discount)
        {
            this._discount = discount;
        }

        public decimal GetPriceWithDiscount()
        {
            return this.Price - (this.Price * this._discount);
        }
    }
}

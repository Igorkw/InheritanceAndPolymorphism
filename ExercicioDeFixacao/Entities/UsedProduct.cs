namespace ExercicioDeFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public string PriceTag()
        {
            return $"{Name} ${Price} (Manufacture date: {ManufactureDate})";
        }
    }
}

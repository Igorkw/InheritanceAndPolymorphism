namespace ExercicioDeFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public string PriceTag()
        {
            return $"{Name} ${Price} (Customs fee: {CustomsFee})";
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}

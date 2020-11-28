namespace INStock.Contracts
{
    public interface IProduct
    {
        public int Quantity { get;set; }
        public string Label { get; set; }
        public decimal Price { get; set; }
    }
}

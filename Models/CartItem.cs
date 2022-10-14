namespace CalProTein.Models
{
    public class CartItem
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Cal { get; set; }
        public int Total
        {
            get { return Quantity * Cal; }
        }

        public int Protein { get; set; }
        public int TotalProtein
        {
            get { return Quantity * Protein; }
        }
       

        public CartItem()
        {
        }

        public CartItem(Product product)
        {
            ProductId = product.Id;
            ProductName = product.Name;
            Cal = (int)product.Cal;
            Protein = (int)product.Protein;
            Quantity = 1;
            
        }

    }
}

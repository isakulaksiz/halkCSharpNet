namespace Encapsulation
{
    public class Product
    {
        private string name;
        private double price;

        public void SetPrice(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("price değeri negatif olamaz");
            }
            price = value;
        }

        public double GetPrice()
        {
            return price;
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("ürün adı boş olmaz");

                name = value;
            }
        }

        public string Description { get; set; } = default!;
        public double Discount { get; private set; }

        public double? Rating { get; set; }


    }

}

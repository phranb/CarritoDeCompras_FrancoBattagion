namespace CarritoDeCompras
{
    public class Carrito
    {
        private int _quantity;
        private double _total;
        private double _discount;
        private double _totalFinal;

        public Carrito()
        {
            Quantity = 0;
        }

        public void CalculateTotal(double price)
        {
            Total = Quantity * price;
        }

        public void ApplyDiscount()
        {
            if (Quantity >= 3 && Quantity <= 5)
            {
                Discount = 0.1;
            }
            else if (Quantity > 5)
            {
                Discount = 0.2;
            }
            else
            {
                Discount = 0.0;
            }
            
            TotalFinal = Total - Total * Discount;
        }
        
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
        
        public double Total
        {
            get => _total;
            set => _total = value;
        }

        public double Discount
        {
            get => _discount;
            set => _discount = value;
        }

        public double TotalFinal
        {
            get => _totalFinal;
            set => _totalFinal = value;
        }
    }
}
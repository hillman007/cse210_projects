using System;

class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        // add product
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // calculate total cost
        public decimal TotalCost()
        {
            decimal productTotal = 0;

            foreach (Product product in _products)
            {
                productTotal += product.TotalCost();
            }

            decimal shippingCost;
            if (_customer.LivesInUSA())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }
            return productTotal + shippingCost;
        }

        // packing label
        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in _products)
            {
                label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }

        // shipping label
        public string GetShippingLabel()
        {
            string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
            return label;
        }
    }
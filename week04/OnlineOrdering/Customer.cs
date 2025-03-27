using System;

class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }
        public Address GetAddress()
        {
            return _address;
        }
        // uses address class to check if customer in USA
        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }
    }
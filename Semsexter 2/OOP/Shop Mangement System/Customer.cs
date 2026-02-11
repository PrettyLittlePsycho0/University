using System;

namespace Classapp
{
    internal class Customer
    {
        public string name;
        public string phoneNumber;
        public int age;
        public string address;

        public Customer(string name, string phoneNumber, int age, string address)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.address = address;
        }

        public Customer(Customer otherCustomer)
        {
            name = otherCustomer.name;
            phoneNumber = otherCustomer.phoneNumber;
            age = otherCustomer.age;
            address = otherCustomer.address;
        }

        public override string ToString()
        {
            return "Phone Number: " + phoneNumber + ", Age: " + age + ", Address: " + address;
        }
    }
}
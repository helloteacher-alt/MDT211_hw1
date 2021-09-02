using System;
using System.Collections.Generic;

namespace T_shirt_order
{   
    class Program
    {
        // 63120501029 ปัญญิศา เอื้อภักดีวงศ์
        static void Main(string[] args)
        {
            Address address = new Address("131/75 ถนนพุทธมณฑล จังหวัดนครปฐม","10180");
            ShoppingCart totaljame = new ShoppingCart(address);
            Tshirt tshirt1 = new Tshirt("L",  "red",  500f, "image1");
            Tshirt tshirt2 = new Tshirt("M", "black", 750f, "image2");
            Tshirt tshirt3 = new Tshirt("S", "white", 625f, "image3");
            User jame = new User("Jame Watson", "jame@gmail.com", totaljame);
            Console.WriteLine("Jame Watson");
            Console.WriteLine("e-mail : jame@gmail.com");
            Console.WriteLine("--------------------");
            Console.WriteLine("Order List");
            Console.WriteLine("--------------------");
            Console.WriteLine("order1 = L, red   , 500 baht , image1");
            Console.WriteLine("order2 = M, black , 750 baht , image2");
            Console.WriteLine("order3 = S, white , 625 baht , image3");
            Console.WriteLine("Address : 131/75 ถนนพุทธมณฑล จังหวัดนครปฐม 10180");
            jame.ShoppingCart.AddTshirt(tshirt1);
            jame.ShoppingCart.AddTshirt(tshirt2);
            jame.ShoppingCart.AddTshirt(tshirt3);
            Console.WriteLine("Total cost is");
            jame.ShoppingCart.TotalCost();
            Console.WriteLine();
            
        }
    }
    class Tshirt
    {
        public string size;
        public string colour;
        public float price;
        public string image;
        public Tshirt(string valueSize, string valueColour, float valuePrice, string valueImage)
        {
            size = valueSize;
            colour = valueColour;
            price = valuePrice;
            image = valueImage;
        }
    }
    class User
    {
        public string name;
        public string email;
        public ShoppingCart ShoppingCart;
        public User(string valueName, string valueEmail,ShoppingCart valueShoppingCart)
        {
            name = valueEmail;
            email = valueEmail;
            ShoppingCart = valueShoppingCart;
        }
        
    }
    class Address
    {
        public string address;
        public string zipcode;
        public Address(string valueAddress,string valueZipcode)
        {
            address = valueAddress;
            zipcode = valueZipcode;
        }
    }
    class ShoppingCart
    {
        private List<Tshirt> orderTshirt;
        public float totalCost = 0;
        public Address address;
        public ShoppingCart(Address valueAddress)
        {
            address= valueAddress;
            orderTshirt = new List<Tshirt>();
        }
        public void AddTshirt(Tshirt tshirt)
        {
            orderTshirt.Add(tshirt);
        }
        public void TotalCost()
        {
            foreach (Tshirt tshirt in orderTshirt)
            {
                totalCost += tshirt.price;
            }
            Console.WriteLine(totalCost);
        }
    }
}

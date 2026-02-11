using System;
using System.ComponentModel;
using System.Data.Common;
using System.Net.Mail;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make Console White
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            // Data Structurs
            List<Product> allProducts = new List<Product>();
            List<Customer> allCustomers = new List<Customer>();
            List<Order> allOrders = new List<Order>();

            // File Paths
            string productsPath = "D:\\Documents\\Projects\\c#\\ConsoleApp1\\products.txt";
            string customersPath = "D:\\Documents\\Projects\\c#\\ConsoleApp1\\customers.txt";
            string ordersPath = "D:\\Documents\\Projects\\c#\\ConsoleApp1\\orders.txt";

            // Loading Data From File Based Database
            LoadProducts(allProducts, productsPath);
            LoadCustomers(allCustomers, customersPath);
            LoadOrders(allOrders, ordersPath, allCustomers);

            // Main Program Loop
            while (true)
            {
                Console.Clear();
                string choice = MainMenu();
                if (choice == "0") break;
                else if (choice == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        choice = ProductSubMenu();
                        if (choice == "0") break;
                        else if (choice == "1")
                        {
                            Console.Clear();
                            Product product = AddNewProduct(allProducts);
                            if (product != null)
                            {
                                allProducts.Add(product);
                                SaveProducts(allProducts, productsPath, true);
                                PauseForKeyPress("Product Added.");
                            }
                        }
                        else if (choice == "2")
                        {
                        startAgain:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("--------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n                 UPDATE PRODUCT                 \n\n" +

                                              "--------------------------------------------------\n\n" +

                                              "You can type \"exit\" to go back anytime.\n"
                            );
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("Enter Product Name: ");
                            string name = Console.ReadLine();
                            if (name.ToLower() == "exit") continue;
                            if (name == "") goto startAgain;
                            bool found = false;
                            for (int i = 0; i < allProducts.Count; i++)
                            {
                                if (allProducts[i].name == name)
                                {
                                    found = true;
                                    if (UpdateProduct(allProducts[i]))
                                    {
                                        SaveProducts(allProducts, productsPath, false);
                                    }
                                    break;
                                }
                            }
                            if (!found)
                            {
                                PauseForKeyPress("Product Not Found.");
                                goto startAgain;
                            }
                        }
                        else if (choice == "3")
                        {
                        startAgain:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("--------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n                 DELETE PRODUCT                 \n\n" +

                                                "--------------------------------------------------\n" +

                                                "You can type \"exit\" to go back anytime.\n"
                            );
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("Enter Product Name: ");
                            string name = Console.ReadLine();
                            if (name.ToLower() == "exit") continue;
                            if (name == "") goto startAgain;
                            bool found = false;
                            for (int i = 0; i < allProducts.Count(); i++)
                            {
                                if (allProducts[i].name == name)
                                {
                                    found = true;
                                    DeleteProduct(allProducts, allProducts[i]);
                                    SaveProducts(allProducts, productsPath, false);
                                    PauseForKeyPress("Product Deleted.");
                                    break;
                                }
                            }
                            if (!found)
                            {
                                PauseForKeyPress("Product Not Found.");
                                goto startAgain;
                            }
                        }
                        else if (choice == "4")
                        {
                            Console.Clear();
                            ViewAllProducts(allProducts);
                            PauseForKeyPress("All Products Displayed.");
                        }
                        else
                        {
                            PauseForKeyPress("Invalid Choice!");
                        }
                    }
                }
                else if (choice == "2")
                {
                    while (true)
                    {
                        Console.Clear();
                        choice = CustomerSubMenu();
                        if (choice == "0")
                        {
                            break;
                        }
                        else if (choice == "1")
                        {
                            Console.Clear();
                            Customer customer = AddNewCustomer(allCustomers);
                            if (customer != null)
                            {
                                allCustomers.Add(customer);
                                SaveCustomers(allCustomers, customersPath, true);
                                PauseForKeyPress("Customer Added.");
                            }
                        }
                        else if (choice == "2")
                        {
                        startAgain:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("---------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n                 UPDATE CUSTOMER                 \n\n" +

                                              "---------------------------------------------------\n\n" +

                                              "You can type \"exit\" to go back anytime.\n"
                            );
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("Enter Customer's Name: ");
                            string name = Console.ReadLine();
                            if (name.ToLower() == "exit") continue;
                            if (name == "") goto startAgain;
                            bool found = false;
                            for (int i = 0; i < allCustomers.Count(); i++)
                            {
                                if (allCustomers[i].name == name)
                                {
                                    found = true;
                                    if (UpdateCustomer(allCustomers[i]))
                                    {
                                        SaveCustomers(allCustomers, customersPath, false);
                                    }
                                    break;
                                }
                            }
                            if (!found)
                            {
                                PauseForKeyPress("Customer Not Found.");
                                goto startAgain;
                            }
                        }
                        else if (choice == "3")
                        {
                        startAgain:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("---------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n                 DELETE CUSTOMER                 \n\n" +

                                              "---------------------------------------------------\n\n" +

                                              "You can type \"exit\" to go back anytime.\n"
                            );
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("Enter Customer Name: ");
                            string name = Console.ReadLine();
                            if (name.ToLower() == "exit") continue;
                            if (name == "") goto startAgain;
                            bool found = false;
                            for (int i = 0; i < allCustomers.Count(); i++)
                            {
                                if (allCustomers[i].name == name)
                                {
                                    found = true;
                                    DeleteCustomer(allCustomers, allCustomers[i]);
                                    SaveCustomers(allCustomers, customersPath, false);
                                    PauseForKeyPress("Customer Deleted.");
                                    break;
                                }
                            }
                            if (!found)
                            {
                                PauseForKeyPress("Customer Not Found.");
                                goto startAgain;
                            }
                        }
                        else if (choice == "4")
                        {
                            Console.Clear();
                            ViewAllCustomers(allCustomers);
                            PauseForKeyPress("");
                        }
                        else
                        {
                            PauseForKeyPress("Invalid Choice!");
                        }
                    }
                }
                else if (choice == "3")
                {
                startAgain:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("---------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                 CREATE NEW SALE                 \n\n" +

                                      "---------------------------------------------------\n\n" +

                                      "You can type \"exit\" to go back anytime.\n"
                    );
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Enter Customer's Name: ");
                    string name = Console.ReadLine();
                    if (name.ToLower() == "exit") continue;
                    if (name == "") goto startAgain;
                comeback:
                    bool found = false;
                    for (int i = 0; i < allCustomers.Count(); i++)
                    {
                        if (allCustomers[i].name == name)
                        {
                            found = true;
                            Console.Clear();
                            Order order = CreateNewSale(allCustomers[i], allProducts);
                            if (order != null)
                            {
                                allOrders.Add(order);
                                SaveOrder(order, ordersPath);
                                PauseForKeyPress("Order Completed.");
                            }
                            
                        }
                    }
                    if (!found)
                    {
                        PauseForKeyPress("Customer Not Found.");
                        Console.Clear();
                        Customer customer = AddNewCustomer(allCustomers);
                        if (customer != null)
                        {
                            allCustomers.Add(customer);
                            SaveCustomers(allCustomers, customersPath, true);
                            PauseForKeyPress("Customer Added.");
                            name = customer.name;
                            goto comeback;
                        }
                    }
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    choice = HistorySubMenu();
                    if (choice == "0")
                    {
                        continue;
                    }
                    else if (choice == "1")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("----------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n                 VIEW ALL HISTORY                 \n\n" +

                                          "----------------------------------------------------\n"
                        );
                        Console.ForegroundColor = ConsoleColor.Black;
                        ViewAllHistory(allOrders);
                        PauseForKeyPress("All Order History Displayed.");
                    }
                    else if (choice == "2")
                    {
                    startAgain:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("-----------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n               VIEW Customer HISTORY               \n\n" +

                                          "-----------------------------------------------------\n\n" +

                                          "You can type \"exit\" to go back anytime.\n"
                        );
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Enter Customer's Name: ");
                        string name = Console.ReadLine();
                        if (name.ToLower() == "exit") continue;
                        if (name == "") goto startAgain;
                        ViewHistoryByName(allOrders, name);
                        PauseForKeyPress("Customer History Displayed.");
                    }
                    else
                    {
                        PauseForKeyPress("Invalid Choice!");
                    }
                }
                else
                {
                    PauseForKeyPress("Invalid Choice!");
                }
            }
        }
       
        static string MainMenu()
        {
            Console.WriteLine("===================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n              SHOP MANGEMENT SYSTEM              \n\n" +

                              "===================================================\n"
            );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("1. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Product Management\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("2. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Customer Management\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("3. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Create New Sale (Order)\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("4. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("View Order History\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. Exit Application\n\n" +
                              "---------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter your choice: ");

            return Console.ReadLine();
        }

        static string ProductSubMenu()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                PRODUCT MANGEMENT                \n\n" +

                              "---------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("1. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Add New Product\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("2. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Update Product\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("3. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Delete Product\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("4. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("View All Products\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. Go Back to Main Menu\n\n" +
                              "---------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter your choice: ");

            return Console.ReadLine();
        }

        static Product AddNewProduct(List<Product> products)
        {
        startAgain:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                 ADD NEW PRODUCT                 \n\n" +

                              "---------------------------------------------------\n\n" +

                              "You can type \"exit\" to go back anytime.\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.Clear();
                goto startAgain;
            }
            if (name.ToLower() == "exit") return null;
            for (int i = 0; i < products.Count; i++)
            {
                if (name == products[i].name)
                {
                    PauseForKeyPress("Product Already Exists.");
                    Console.Clear();
                    goto startAgain;
                }
            }
        price:
            Console.Write("\nEnter Product Price: $");
            string price = Console.ReadLine();
            if (price.ToLower() == "exit") return null;
            if (price == "") goto price;
            if (!double.TryParse(price, out double doubleValuePrice))
            {
                Console.WriteLine("\nInvalid Input!");
                goto price;
            }
            
        discount:
            Console.Write("\nDo you want to add a discount for this product? (Yes/No): ");
            string res = Console.ReadLine();
            if (res.ToLower() == "exit") return null;
            if (res.ToLower() == "yes")
            {
            discountPercentage:
                Console.Write("\nEnter Discount Percentage: ");
                string percentage = Console.ReadLine();
                if (percentage.ToLower() == "exit") return null;
                if (percentage == "") goto discountPercentage;
                if (!double.TryParse(percentage, out double doubleValuePercentage))
                {
                    Console.WriteLine("\nInvalid Input!");
                    goto discountPercentage;
                }
                return new Product(name, doubleValuePrice, doubleValuePercentage);
            }
            else if (res.ToLower() == "no")
            {
                return new Product(name, doubleValuePrice);
            }
            else
            {
                goto discount;
            }
        }

        static bool UpdateProduct(Product product)
        {
            string lastOption = "Cancel";
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("--------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n                 UPDATE PRODUCT                 \n\n" +

                                  "--------------------------------------------------\n\n" +

                                  "You can type \"exit\" to go back anytime.\n"
                );
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("What do you want to update?\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Product Price (Current: $" + product.purchasePrice + ")\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Product Discount (Current: " + product.discount + "%)\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0. " + lastOption + "\n\n" +
                                  "---------------------------------------------------\n"
                );
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "exit") return false;
                if (choice == "0")
                {
                    if (lastOption == "Done? Go Back") break;
                    return false;
                }

                else if (choice == "1")
                {
                price:
                    Console.Write("Enter new price: $");
                    string price = Console.ReadLine();
                    if (price.ToLower() == "exit") return false;
                    if (price == "") goto price;
                    if (!double.TryParse(price, out double doubleValuePrice))
                    {
                        Console.WriteLine("\nInvalid Input\n");
                        goto price;
                    }
                    product.purchasePrice = doubleValuePrice;
                    product.CalculateSalePrice();
                    lastOption = "Done? Go Back";
                }
                else if (choice == "2")
                {
                discount:
                    Console.Write("Enter new discount percentage: ");
                    string discount = Console.ReadLine();
                    if (discount.ToLower() == "exit") return false;
                    if (discount == "") goto discount;
                    if (!double.TryParse(discount, out double doubleValueDiscount))
                    {
                        Console.WriteLine("\nInvalid Input\n");
                        goto discount;
                    }
                    product.discount = doubleValueDiscount;
                    product.CalculateSalePrice();
                    lastOption = "Done? Go Back";
                }
                else
                {
                    PauseForKeyPress("Invalid Choice!");
                }
            }
            return true;
        }

        static void DeleteProduct(List<Product> products, Product product)
        {
            products.Remove(product);
        }

        static void ViewAllProducts(List<Product> products)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                 VIEW ALL PRODUCT                 \n\n" +

                              "----------------------------------------------------\n"
            );
            for (int i = 0; i < products.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(i + 1 + ". Name: " + products[i].name);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t" + products[i].ToString() + "\n");
            }
        }

        static string CustomerSubMenu()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                CUSTOMER MANGEMENT                \n\n" +

                              "----------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("1. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Add New Customer\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("2. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Update Customer\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("3. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Delete Customer\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("4. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("View All Customers\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. Go Back to Main Menu\n\n" +
                              "----------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter your choice: ");

            return Console.ReadLine();
        }

        static bool IsAllDigits(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return s.Length > 0;
        }

        static Customer AddNewCustomer(List<Customer> customers)
        {
        startAgain:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                 ADD NEW CUSTOMER                 \n\n" +

                              "----------------------------------------------------\n\n" +

                              "You can type \"exit\" to go back anytime.\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter Customer's Name: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") return null;
            if (name == "")
            {
                Console.Clear();
                goto startAgain;
            }
            for (int i = 0; i < customers.Count; i++)
            {
                if (name == customers[i].name)
                {
                    PauseForKeyPress("Customer Already Exists.");
                    Console.Clear();
                    goto startAgain;
                }
            }
        phoneNo:
            Console.Write("\nEnter Customer's Phone Number: ");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber.ToLower() == "exit") return null;
            if (phoneNumber == "") goto phoneNo;
            if (!IsAllDigits(phoneNumber))
            {
                Console.WriteLine("\nInvalid Input!");
                goto phoneNo;
            } 
        age:
            Console.Write("\nEnter Customer's age: ");
            string age = Console.ReadLine();
            if (age.ToLower() == "exit") return null;
            if (age == "") goto age;
            if (!int.TryParse(age, out int intValueAge))
            {
                Console.WriteLine("\nInvalid Input!");
                goto age;
            }
        address:
            Console.Write("\nEnter Customer's Address: ");
            string address = Console.ReadLine();
            if (address.ToLower() == "exit") return null;
            if (address == "") goto address;

            return new Customer(name, phoneNumber, intValueAge, address);
        }

        static bool UpdateCustomer(Customer customer)
        {
            string lastOption = "Cancel";
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("---------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n                 UPDATE CUSTOMER                 \n\n" +

                                  "---------------------------------------------------\n\n" +

                                  "You can type \"exit\" to go back anytime.\n"
                );
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("What do you want to update?\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Customer's Phone Number (Current: " + customer.phoneNumber + ")\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Customer's Age (Current: " + customer.age + ")\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("3. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Customer's Address (Current: " + customer.address + ")\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0. " + lastOption + "\n\n" +
                                "----------------------------------------------------\n"
                );
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "exit") return false;
                if (choice == "0")
                {
                    if (lastOption == "Done? Go Back") break;
                    return false;
                }
                else if (choice == "1")
                {
                phoneNo:
                    Console.Write("Enter new phone number: ");
                    string phoneNumber = Console.ReadLine();
                    if (phoneNumber.ToLower() == "exit") return false;
                    if (phoneNumber == "") goto phoneNo;
                    if (!IsAllDigits(phoneNumber))
                    {
                        Console.WriteLine("\nInvalid Input!\n");
                        goto phoneNo;
                    }
                    customer.phoneNumber = phoneNumber;
                    lastOption = "Done? Go Back";
                }
                else if (choice == "2")
                {
                age:
                    Console.Write("Enter new age: ");
                    string age = Console.ReadLine();
                    if (age.ToLower() == "exit") return false;
                    if (age == "") goto age;
                    if (!int.TryParse(age, out int intValueAge))
                    {
                        Console.WriteLine("\nInvalid Input\n");
                        goto age;
                    }
                    customer.age = intValueAge;
                    lastOption = "Done? Go Back";
                }
                else if (choice == "3")
                {
                address:
                    Console.Write("Enter new address: ");
                    string address = Console.ReadLine();
                    if (address.ToLower() == "exit") return false;
                    if (address == "") goto address;
                    customer.address = address;
                    lastOption = "Done? Go Back";
                }
                else
                {
                    PauseForKeyPress("Invalid Choice!");
                }
            }
            return true;
        }

        static void DeleteCustomer(List<Customer> customers, Customer customer)
        {
            customers.Remove(customer);
        }

        static void ViewAllCustomers(List<Customer> customers)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                VIEW ALL CUSTOMERS                \n\n" +

                              "----------------------------------------------------\n"
            );
            for (int i = 0; i < customers.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(i + 1 + ". Name: " + customers[i].name);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t" + customers[i].ToString() + "\n");
            }
        }

        static Order CreateNewSale(Customer customer, List<Product> products)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                 CREATE NEW SALE                 \n\n" +

                              "---------------------------------------------------\n\n" +

                              "You can type \"exit\" to go back anytime.\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Customer Details:\n\n" +
                          "Name: " + customer.name + ", Phone Number: " + customer.phoneNumber + ", Age: " + customer.age + ", Address: " + customer.address + "\n\n"
            );
            List<OrderItem> items = new List<OrderItem>();
            int itemsCount = 0;
            while (true)
            {
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();
                if (name.ToLower() == "exit")
                {
                    if (items.Count == 0) return null;
                    return new Order(customer, items);
                }
                bool found = false;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].name == name)
                    {
                        found = true;
                    quantity:
                        Console.Write("Enter Quantity: ");
                        string quantity = Console.ReadLine();
                        if (quantity.ToLower() == "exit") return null;
                        if (quantity == "") goto quantity;
                        if (!int.TryParse(quantity, out int intValueQuantity))
                        {
                            Console.WriteLine("\nInvalid Input!\n");
                        }
                        items.Add(new OrderItem(products[i], intValueQuantity));
                        itemsCount++;
                    }
                }
                if (!found)
                {
                    PauseForKeyPress("Product Not Found.");
                    Console.WriteLine("\n");
                }
            }
        }

        static string HistorySubMenu()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                VIEW ORDER HISTORY                \n\n" +

                              "----------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("1. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("View All Orders\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("2. "); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("View Orders by Customer Name\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. Go Back to Main Menu\n\n" +
                              "----------------------------------------------------\n"
            );
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter your choice: ");

            return Console.ReadLine();
        }

        static void ViewAllHistory(List<Order> orders)
        {
            for (int i = 0; i < orders.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i + 1 + ". Customer: " + orders[i].customer.name);
                for (int j = 0; j < orders[i].items.Count(); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(orders[i].items[j].product.name + ", " + orders[i].items[j].quantity + ", " + orders[i].items[j].totalPrice);
                }
                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Grand total: " + orders[i].totalPrice);
            }
        }

        static void ViewHistoryByName(List<Order> orders, string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Customer: " + name);
            for (int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].customer.name == name)
                {  
                    for (int j = 0; j < orders[i].items.Count(); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.Write(" | ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(orders[i].items[j].product.name + ", " + orders[i].items[j].quantity + ", " + orders[i].items[j].totalPrice);
                    }
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Grand total: " + orders[i].totalPrice);
                }
            }
        }

        static string ParseData(string record, int field, char separator)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == separator)
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[i];
                }
            }
            return item;
        }

        static void LoadProducts(List<Product> products, string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                return;
            }
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                if (record == "") continue;
                products.Add(new Product(ParseData(record, 1, ','), double.Parse(ParseData(record, 2, ',')), double.Parse(ParseData(record, 3, ','))));
            }
            file.Close();
        }

        static void LoadCustomers(List<Customer> customers, string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                return;
            }
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                if (record == "") continue;
                customers.Add(new Customer(ParseData(record, 1, ','), ParseData(record, 2, ','), int.Parse(ParseData(record, 3, ',')), ParseData(record, 4, ',')));
            }
            file.Close();
        }

        static void LoadOrders(List<Order> orders, string path, List<Customer> customers)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                return;
            }
            List<OrderItem> items = new List<OrderItem>();
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                string customerName = ParseData(record, 1, ',');
                for (int i = 0; i < customers.Count(); i++)
                {
                    if (customers[i].name == customerName)
                    {
                        int itemCount = int.Parse(ParseData(record, 2, ','));
                        string itemsList = ParseData(record, 3, ',');
                        for (int j = 1; j <= itemCount * 4; j += 4)
                        {
                            items.Add(
                                new OrderItem(
                                    new Product(ParseData(itemsList, j, '.'), double.Parse(ParseData(itemsList, j + 1, '.')), double.Parse(ParseData(itemsList, j + 2, '.'))),
                                    int.Parse(ParseData(itemsList, j + 3, '.'))
                                )
                            );
                        }
                        orders.Add(new Order(customers[i], items));
                        break;
                    }
                }
            }
            file.Close();
        }

        static void SaveProducts(List<Product> products, string path, bool appendSave)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            bool isEmpty = appendSave ? false : true;
            StreamWriter file = new StreamWriter(path, appendSave);
            int start = 0;
            if (appendSave) start = products.Count - 1;
            for (int i = start; i < products.Count; i++)
            {
                if (!isEmpty) file.WriteLine();
                file.Write(products[i].name + "," + products[i].purchasePrice + "," + products[i].discount);
                isEmpty = false;
            }
            file.Flush();
            file.Close();
        }

        static void SaveCustomers(List<Customer> customers, string path, bool appendSave)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            bool isEmpty = appendSave ? false : true;
            StreamWriter file = new StreamWriter(path, appendSave);
            int start = 0;
            if (appendSave) start = customers.Count - 1;
            for (int i = start; i < customers.Count; i++)
            {
                if (!isEmpty) file.WriteLine();
                file.Write(customers[i].name + "," + customers[i].phoneNumber + "," + customers[i].age + "," + customers[i].address);
                isEmpty = false;
            }
            file.Flush();
            file.Close();
        }

        static void SaveOrder(Order order, string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string content = File.ReadAllText(path);
            bool isEmpty = string.IsNullOrWhiteSpace(content);

            using (StreamWriter file = new StreamWriter(path, true))
            {
                if (!isEmpty)
                {
                    file.WriteLine();
                }

                file.Write(order.customer.name + "," + order.items.Count + ",");
                for (int i = 0; i < order.items.Count; i++)
                {
                    file.Write(order.items[i].product.name + "." +
                            order.items[i].product.purchasePrice + "." +
                            order.items[i].product.discount + "." +
                            order.items[i].quantity + ".");
                }
            }
        }

        static void PauseForKeyPress(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n" + message + " Press any key to continue...");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
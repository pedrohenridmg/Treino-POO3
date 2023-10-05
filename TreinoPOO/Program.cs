﻿using System;
using TreinoPOO.Entities;
using TreinoPOO.Entities.Enum;

namespace TreinoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product name: ");
                string Pname = Console.ReadLine();
                Console.Write("Product price: ");
                double Pprice = double.Parse(Console.ReadLine());

                Product product = new Product(Pname, Pprice);

                Console.Write("Quantity: ");
                int Pquantity = int.Parse(Console.ReadLine());

                OrderItem orderitem = new OrderItem(Pquantity, Pprice, product);  

                order.AddItem(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
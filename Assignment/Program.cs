using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        class Bank
        {
            int amount;
            public Bank()

            {
                Console.Write(" Enter initial  amount in Account : ");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            public void Display()
            {
                Console.WriteLine("Amount in Bank Account :" + amount);
            }

            public void Deposit()
            {
                Console.WriteLine("Enter Deposit amount  : ");
                int Deam = Convert.ToInt32(Console.ReadLine());
                amount = amount + Deam;
                Console.WriteLine(" Deposited " + Deam + " in account ");
            }

            public void withdrawl()
            {
                Console.Write(" Enter amount to withdraw  : ");
                int Wiam = Convert.ToInt32(Console.ReadLine());

                if (Wiam > amount)
                {
                    Console.WriteLine("Not enough Funds");

                }
                else
                {
                    amount = amount - Wiam;
                    Console.WriteLine("Withdrew" + Wiam + " from account");
                }
            }

            static void Main(string[] args)
            {
                Bank b = new Bank();
                b.Display();
                b.Deposit();

                b.Display();
                b.withdrawl();

                b.Display();
                b.withdrawl();

                b.Display();
            }
        }
    }
}

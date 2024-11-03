using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_01.Model
{
    public interface ICallable
    {
        void Call(string number);
    }

    public interface IBrowsable
    {
        void Browse(string url);
    }

    public class Smartphone : ICallable, IBrowsable
    {
        public void Call(string number)
        {
            bool isAllDigits = true;
            foreach (char c in number) 
            {
                if (!char.IsDigit(c))
                {
                    isAllDigits = false;
                    break;
                }
            }
            if (number.All(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void Browse(string url)
        {
            bool nodigit = true;
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    nodigit = false;
                    break;
                }
            }
            if (nodigit)
            { 
                Console.WriteLine($"Browsing: {url}!"); 
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }

        }
    }
}

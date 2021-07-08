using System;
using Iterator_Method.Interfaces;
using Iterator_Method.Models;
using Iterator_Method.Services;

namespace Iterator_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable company = new Company("IT");
            IEnumerator companyEnumerator = new CompanyEnumerator(company);
            while (!companyEnumerator.IsDone())
            {
                Console.WriteLine($"{(companyEnumerator.Next() as Worker).Name} работает в компании: {(company as Company).Title}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SportsStore.UnitTests
{
    public class TestBase
    {
        public void Describes(string description)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(description);
            Console.WriteLine("-------------------------------");
        }

        public void IsPending()
        {
            Console.WriteLine(" -- Is Pending -- ");
            Assert.Inconclusive();
        }
    }
}

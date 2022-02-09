using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PartyBuilder();
            Party party1 = builder.CreateIndividual()
                                  .SetNationalCode("5050062330")
                                  .SetName("Milad", "Abdi")
                                  .Build();

            Party party2 = builder.CreateLegal()
                                  .SetRegistrationCode("222222315")
                                  .SetTitle("TestTitle")
                                  .Build();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_study_p339
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string Tostring()
        {
            return $"{From} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Rtransaction tr1 = new Rtransaction
            {
                from = "Alice",
                To = "Bob",
                Amount = 100
            };
            Rtransaction tr2 = new Rtransaction
            {
                from = "Alice",
                To = "Charlie",
                Amount = 100
            };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainCrunchDecoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to encode:");
            string input = Console.ReadLine();
            string encoded = DecoderRing.Encode(input);
            Console.WriteLine(encoded);

            //With generalization
            Console.WriteLine("Enter a new message to encode:");
            string input2 = Console.ReadLine();
            string encoded2 = DecoderRing.Decode(input2, 13);
            Console.WriteLine("Your message encoded: " + encoded2);
            string encoded3 = DecoderRing.Decode(encoded2, -13);
            Console.WriteLine("Your message decoded: " + encoded3);
        }
    }
}

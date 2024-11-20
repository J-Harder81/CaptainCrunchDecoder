using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaptainCrunchDecoder
{
    internal class DecoderRing
    {
        public static string Encode(string input)
        {
            char[] encoded = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLower(c))
                {
                    encoded[i] = (char)((c - 'a' + 13) % 26 + 'a');
                }
                else if (char.IsUpper(c))
                {
                    encoded[i] = (char)((c - 'A' + 13) % 26 + 'A');
                }
                else
                {
                    encoded[i] = c;
                }
            }

            return new string(encoded);
        }
        public static string Decode(string input, int shift)
        {
            char[] decoded = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLower(c))
                {
                    decoded[i] = (char)((c - 'a' + shift + 26) % 26 + 'a');
                }
                else if (char.IsUpper(c))
                {
                    decoded[i] = (char)((c - 'A' + shift + 26) % 26 + 'A');
                }
                else
                {
                    decoded[i] = c;
                }
            }
            return new string(decoded);
        }
    }
}

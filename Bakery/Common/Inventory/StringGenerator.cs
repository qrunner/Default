using System;
using System.Linq;

namespace Fortius.Inventory
{
    public static class StringGenerator
    {
        const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string Generate(byte length)
        {
            var random = new Random();
            return new string(Enumerable.Repeat(Chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
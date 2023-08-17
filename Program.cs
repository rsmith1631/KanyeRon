using KanyeRon;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Xml.Linq;

namespace KanyeRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            Console.ReadLine();
        }
    }
}
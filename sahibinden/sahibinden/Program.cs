using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using sahibinden.Service;

namespace sahibinden
{
    class Program
    {
        static void Main(string[] args)
        {

            CrawlService.getNeededInfo();

            Console.ReadLine();
        }

    }
}

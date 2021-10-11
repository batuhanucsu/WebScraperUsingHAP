using HtmlAgilityPack;
using sahibinden.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sahibinden.Service
{
    public static class CrawlService
    {
        //public static async Task getNeededInfo()
        //{
        //    List<String> LinkList = new List<string>();
        //    var url = "https://www.sahibinden.com/";
        //    var httpClient = new HttpClient();
        //    var html = await httpClient.GetStringAsync(url);
        //    var htmlDocument = new HtmlDocument();
        //    htmlDocument.LoadHtml(html);

        //    var li = htmlDocument.DocumentNode.SelectNodes("//div[@class = 'uiBox showcase']//li").ToList();

        //    var products = new List<Product>();

        //    foreach (var elem in li)
        //    {
               
        //        var product = new Product
        //        {
        //            Title =elem?.Descendants("span")?.FirstOrDefault()?.InnerText,
        //            Link = elem?.Descendants("a")?.FirstOrDefault()?.ChildAttributes("href")?.FirstOrDefault()?.Value,
        //            ImgUrl = elem.Descendants("img")?.FirstOrDefault()?.ChildAttributes("src")?.FirstOrDefault()?.Value
        //        };

        //        products.Add(product);

        //    }

        //    int index = 1;
        //    foreach(var item in products)
        //    {
        //        Console.WriteLine(index + ") \n");
        //        Console.WriteLine("Title: " + item.Title + "\n" + "Link: " + item.Link + "\n" + "Image Url: " + item.ImgUrl + "\n\n\n\n");
        //        index++;
        //    }

        //}

        public static void getNeededInfo()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.sahibinden.com/");
            var li = doc.DocumentNode.SelectNodes("//div[@class = 'uiBox showcase']//li").ToList();

            var products = new List<Product>();

            foreach (var elem in li)
            {

                var product = new Product
                {
                    Title = elem?.Descendants("span")?.FirstOrDefault()?.InnerText,
                    Link = elem?.Descendants("a")?.FirstOrDefault()?.ChildAttributes("href")?.FirstOrDefault()?.Value,
                    ImgUrl = elem.Descendants("img")?.FirstOrDefault()?.ChildAttributes("src")?.FirstOrDefault()?.Value
                };

                products.Add(product);

            }

            int index = 1;
            foreach (var item in products)
            {
                Console.WriteLine(index + ") \n");
                Console.WriteLine("Title: " + item.Title + "\n" + "Link: " + item.Link + "\n" + "Image Url: " + item.ImgUrl + "\n\n\n\n");
                index++;
            }


        }

    }
}

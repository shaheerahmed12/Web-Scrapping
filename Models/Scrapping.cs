using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace Web_Scrapping.Models
{
    public class Scrapping
    {
        public Dictionary<string, List<curren>> GetCurrency()
        {
            Dictionary<string, List<curren>> currencyWithKey = new Dictionary<string, List<curren>>();
            List<curren> currency = new List<curren>();
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load("https://www.forex.pk/");
            var nodes = doc.DocumentNode.SelectNodes("//table[2]");


            foreach (var node in nodes)
            {
                HtmlNodeCollection tdNodes = node.SelectNodes(".//td");
                for (int i = 0; i < tdNodes.Count; i = i + 5)
                {

                    currency.Add(new curren
                    {
                        Currency = tdNodes[i].InnerText,
                        Symbol = tdNodes[i + 1].InnerText,
                        Buying = tdNodes[i + 2].InnerText,
                        Selling = tdNodes[i + 3].InnerText
                    });
                }
                currencyWithKey["Random"] = currency;
            }
            return currencyWithKey;
        }

    }
    }
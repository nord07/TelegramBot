using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    internal class ParserLink
    {
        public static List<string> AngleSharp(string urlAddress)
        {
            List<string> hrefTags = new List<string>();
            var Html = GetCode(urlAddress);
            var parser = new HtmlParser();
            var document = parser.ParseDocument(Html);
            var elements = document.QuerySelectorAll("img");//.Where(x => x.ClassName != null && x.ClassName.Contains("teaser__img"));

            foreach (IElement element in elements)
            {
                hrefTags.Add(element.GetAttribute("src"));
            }

            return hrefTags;
        }
        public static String GetCode(string urlAddress)
        {
            string data = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);

            Cookie cookie = new Cookie
            {
                Name = "beget",
                Value = "begetok"
            };

            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Uri(urlAddress), cookie);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }
                data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }
            return data;
        }
    }
}

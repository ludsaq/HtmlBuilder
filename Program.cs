using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlBuilder
{
    class HtmlBuilder 
    {
        private StringBuilder HeaderHtml = new StringBuilder("<html>< head >< meta charset = "+"UTF-8" + "> </head >", 100);

        public HtmlBuilder(Dictionary<string, string> ArrayEmail) 
        {
            File.WriteAllText(@"C:\index.html",HeaderHtml.AppendLine(ContentHtml(ArrayEmail).ToString()).ToString());
        }

        public StringBuilder ContentHtml(Dictionary<string, string> ArrayEmail) 
        {
            StringBuilder ContentHtml = new StringBuilder("<body>",1000);

            foreach (var People in ArrayEmail) 
            {
                ContentHtml.AppendLine("<a href="+People.Value+">"+People.Key+"</a>");
            }

            ContentHtml.AppendLine("</body>");

            return ContentHtml;
        }
    }
    class MainLogic
    {
        static void Main(string[] args)
        {
        }
    }
}

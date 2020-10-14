using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlBuilder
{
    class HtmlBuilder 
    {
        private StringBuilder HeaderHtml = new StringBuilder("<html><head>< meta charset = "+"UTF-8" + "> </head >", 100);

        public HtmlBuilder(Dictionary<string, string> arrayEmail) 
        {
            File.WriteAllText(@"C:\test\index.html",HeaderHtml.AppendLine(contentHtml(arrayEmail).ToString()).ToString());
        }

        public StringBuilder contentHtml(Dictionary<string, string> arrayEmail) 
        {
            StringBuilder contentHtml = new StringBuilder("<body>",1000);

            foreach (var people in arrayEmail) 
            {
                contentHtml.AppendLine("<a href="+ people.Key+">"+ people.Value + "</a>");
            }

            contentHtml.AppendLine("</body>");
            contentHtml.AppendLine("</html>");

            return contentHtml;
        }
    }
    class MainLogic
    {
        static void Main(string[] args)
        {
            Dictionary<String, string> arrayEmail = new Dictionary<string, string>();
            arrayEmail.Add("Maxim@gmail.com", "Maxim<script>alert('Name!')</script>");

            HtmlBuilder htmlDocument = new HtmlBuilder(arrayEmail);
        }
    }
}

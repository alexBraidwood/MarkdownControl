using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarkdownParser.Test
{
    [TestFixture]
    public class ParserTests
    {
        [TestCase(Category = "Entry Point Tests")]
        public void MarkdownToString()
        {
            string htmlFromMarkdown = MarkdownParser.MarkdownToString("#Hello!", MarkdownExtension.Smart, MarkdownFormat.Html);
            Assert.AreEqual(htmlFromMarkdown, "<h1>Hello!</h1>");
        }

        [TestCase(Category = "XAML Tests")]
        public void MarkdownHyperlinkToXaml()
        {
            string xamlFromMarkdown = MarkdownParser.MarkdownToString("[Hello!](www.google.com)", MarkdownExtension.Smart, MarkdownFormat.WpfXaml);
            Assert.AreEqual(xamlFromMarkdown, "<Hyperlink NavigateUri=\"www.google.com\">Hello!</Hyperlink>");
        }
    }
}

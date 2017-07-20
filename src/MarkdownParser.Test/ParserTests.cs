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

        [TestCase(Category = "Entry Point Tests")]
        public void ReferenceParse()
        {
            var markdownElement = MarkdownParser.ParseReferences("#Hello!", MarkdownExtension.Smart);
            Assert.NotNull(markdownElement);
        }
    }
}

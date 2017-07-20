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
        [TestCase]
        public void EntryPointTest()
        {
            MarkdownParser.MarkdownToString("Hello!", MarkdownExtension.Smart, MarkdownFormat.Html);
        }
    }
}

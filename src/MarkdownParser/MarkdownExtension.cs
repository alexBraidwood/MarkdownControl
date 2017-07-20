using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownParser
{
    public enum MarkdownExtension
    {
        Smart = 0x01,
        Notes = 0x02,
        FilterHtml = 0x04,
        FilterStyles = 0x08,
        Strike = 0x10
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownParser.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public class MarkdownElement
    {
        public MarkdownKey Key;
        public ElementContents Contents;
        public MarkdownElement[] ChildElements;
        public MarkdownElement NextElement;
    }
}

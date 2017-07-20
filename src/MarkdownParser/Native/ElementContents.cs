using System.Runtime.InteropServices;

namespace MarkdownParser.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class ElementContents
    {
        public string Contents;
        public Link Link;
    }
}
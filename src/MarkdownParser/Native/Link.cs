using System.Runtime.InteropServices;

namespace MarkdownParser.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class Link
    {
        public MarkdownElement LabelElement;
        public string Url;
        public string Title;
    }
}

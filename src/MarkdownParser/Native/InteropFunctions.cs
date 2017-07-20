using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MarkdownParser.Native
{
    public class InteropFunctions
    {
        private const string DllName = "peg-markdown.dll";

        [DllImport(DllName, EntryPoint = "markdown_to_string", CharSet = CharSet.Ansi)]
        internal static extern string MarkdownToStringInternal(
            StringBuilder text,
            MarkdownExtension extensions,
            MarkdownFormat outputFormat);
    }
}

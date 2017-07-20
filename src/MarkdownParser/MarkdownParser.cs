using System;
using System.Runtime.InteropServices;

namespace MarkdownParser
{
    public class MarkdownParser
    {
        public static string MarkdownToString(string text, MarkdownExtension extensions, MarkdownFormat outputFormat)
        {
            return Marshal.PtrToStringAuto(NativeFunctions.MarkdownToStringInternal(text, extensions, outputFormat));
        }
    }
}

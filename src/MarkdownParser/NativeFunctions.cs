using System;
using System.Runtime.InteropServices;

namespace MarkdownParser
{
    public class NativeFunctions
    {
        [DllImport("libpeg-markdown.a", EntryPoint = "markdown_to_string")]
        internal static extern IntPtr MarkdownToStringInternal(
            [MarshalAs(UnmanagedType.LPStr)] string text,
            MarkdownExtension extensions,
            MarkdownFormat outputFormat);
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MarkdownParser.Native;

namespace MarkdownParser
{
    public class MarkdownParser
    {
        public static string MarkdownToString(string text, MarkdownExtension extensions, MarkdownFormat outputFormat)
        {
            var builder = new StringBuilder(text);
            return InteropFunctions.MarkdownToStringInternal(builder, extensions, outputFormat);
        }

        public static MarkdownElement[] ParseReferences(string text, MarkdownExtension extensions)
        {
            var builder = new StringBuilder(text);
            var ptr = InteropFunctions.ParseReferencesInternal(builder, extensions);
            var result = Marshal.PtrToStructure<MarkdownElement[]>(ptr);
            return result;
        }
    }
}

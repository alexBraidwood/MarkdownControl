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

        [DllImport(DllName, EntryPoint = "parse_references", CharSet = CharSet.Ansi)]
        internal static extern IntPtr ParseReferencesInternal(
            StringBuilder text,
            MarkdownExtension extensions);

        [DllImport(DllName, EntryPoint = "parse_notes", CharSet = CharSet.Ansi)]
        internal static extern IntPtr ParseNotesInternal(
            StringBuilder text,
            MarkdownExtension extensions,
            MarkdownElement[] referencesList);

        [DllImport(DllName, EntryPoint = "parse_markdown", CharSet = CharSet.Ansi)]
        internal static extern IntPtr ParseMarkdownInternal(
            StringBuilder text,
            MarkdownExtension extensions,
            MarkdownElement[] referencesList,
            MarkdownElement[] notesList);
    }
}

namespace MarkdownParser
{
    public enum MarkdownKey
    {
        List,   /* A generic list of values.  For ordered and bullet lists, see below. */
        Raw,    /* Raw markdown to be processed further */
        Space,
        Linebreak,
        Ellipsis,
        Emdash,
        Endash,
        Apostrophe,
        Singlequoted,
        Doublequoted,
        Str,
        Link,
        Image,
        Code,
        Html,
        Emph,
        Strong,
        Strike,
        Plain,
        Para,
        Listitem,
        Bulletlist,
        Orderedlist,
        H1, H2, H3, H4, H5, H6,  /* Code assumes that these are in order. */
        Blockquote,
        Verbatim,
        Htmlblock,
        Hrule,
        Reference,
        Note
    }
}
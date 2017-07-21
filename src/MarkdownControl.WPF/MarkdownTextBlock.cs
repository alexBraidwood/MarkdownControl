using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace MarkdownControl.WPF
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MarkdownControl.WPF"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MarkdownControl.WPF;assembly=MarkdownControl.WPF"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    [ContentProperty("MarkdownText")]
    [Localizability(LocalizationCategory.Text)]
    public class MarkdownTextBlock : Control
    {
        public static readonly DependencyProperty MarkdownTextProperty =
            DependencyProperty.Register("MarkdownText", typeof(string), typeof(MarkdownTextBlock),
                new FrameworkPropertyMetadata(string.Empty,
                    FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender,
                    MarkdownTextBlock.OnMarkdownTextChanged));

        static MarkdownTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MarkdownTextBlock), new FrameworkPropertyMetadata(typeof(MarkdownTextBlock)));
        }

        [Localizability(LocalizationCategory.Text)]
        public string MarkdownText
        {
            get { return this.GetValue(MarkdownTextBlock.MarkdownTextProperty) as string; }
            set { this.SetValue(MarkdownTextBlock.MarkdownTextProperty, (object) value); }
        }

        internal void UpdateWithMarkdown(string newMarkdown)
        {
            // Get new inlines from markdown

            // Set new inlines

            // Raise events
        }

        private static void OnMarkdownTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            OnMarkdownTextChanged(d, args.NewValue as string);
        }

        private static void OnMarkdownTextChanged(DependencyObject d, string newMarkdown)
        {
            var markdownBlock = (MarkdownTextBlock) d;
            markdownBlock.UpdateWithMarkdown(newMarkdown);
        }

    }
}

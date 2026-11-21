using Kahnban_ToDo.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace Kahnban_ToDo
{
    internal class PrintService
    {
        // CONSTANTS
        private const string PLACEHOLDER_CSS = "@STYLE_CSS";
        private const string PLACEHOLDER_TITLE = "@Title";
        private const string PLACEHOLDER_BODY = "@Body";

        private static readonly Regex ParagraphBreak = new(@"\r?\n\s*\r?\n", RegexOptions.Compiled);

        public string GenerateHtml(TextReference textReference)
        {
            string html = Resources.TextReference;
            string css = Resources.Style;

            string title = textReference.Title;
            string body = BuildParagraphs(textReference.Content);

            html = html.Replace(PLACEHOLDER_CSS, css);
            html = html.Replace(PLACEHOLDER_TITLE, title);
            html = html.Replace(PLACEHOLDER_BODY, body);

            return html;
        }

        private static string BuildParagraphs(string? content)
        {
            var paragraphs = ParagraphBreak
                .Split(content ?? string.Empty)
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .Select(p => "<p>" + WebUtility.HtmlEncode(p.Trim())
                    .Replace("\r\n", "<br />")
                    .Replace("\n", "<br />") + "</p>");

            return string.Join(Environment.NewLine, paragraphs);
        }
    }
}

﻿using Ganss.XSS;

namespace Academy.Application.Security
{
    public static class XssSecurity
    {
        public static string SanitizeText(this string text)
        {
            var htmlSanitizer = new HtmlSanitizer();

            htmlSanitizer.KeepChildNodes = true;

            htmlSanitizer.AllowDataAttributes = true;

            return htmlSanitizer.Sanitize(text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Downloader
{
    internal class UrlToken
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string FileName { get; private set; }

        public override string ToString()
        {
            return Name + " (" + FileName + ")";
        }

        public static UrlToken Parse(string token)
        {
            UrlToken urlToken = null;

            string[] lstParts = token.Split(new char[] { '|' });
            if (lstParts.Length >= 2)
            {
                urlToken = new UrlToken();
                urlToken.Name = lstParts[0];
                urlToken.Url = lstParts[1];

                Uri uri = new Uri(urlToken.Url);
                urlToken.FileName = Path.GetFileName(uri.LocalPath);
            }

            return urlToken;
        }
    }
}

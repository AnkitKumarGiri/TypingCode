using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TypingCodeLibrary
{
    public class TypingCode
    {
        public TypingCode()
        {

        }
        public string FetchText()
        {
            string result;
            string url = "https://raw.githubusercontent.com/AnkitKumarGiri/NameInIndiaTeam/master/runme.cpp";
            var httpRequestInfo = HttpWebRequest.CreateHttp(url);
            var httpResponseInfo = httpRequestInfo.GetResponse() as HttpWebResponse;

            var responseStream = httpResponseInfo.GetResponseStream();

            using (var sr = new StreamReader(responseStream))
            {
                var webPage = sr.ReadToEnd();
                Debug.WriteLine(webPage.ToString());
                result = webPage.ToString();
            }

            return result;
                return "The quick brown fox jumps over the lazy dog";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinHttp;

namespace PacketSender
{
    public class WinHTTP
    {
        public static string SendRequest(string method, string url, string userAgent, string Referer, string cookie, string contentType, string[] headernames, string[] headers, string data)
        {
            WinHttp.WinHttpRequest req = new WinHttpRequest();

            try
            {
                req.Open(method, url, true);
                if (String.IsNullOrWhiteSpace(userAgent) == false) req.SetRequestHeader("User-Agent", userAgent);
                if (String.IsNullOrWhiteSpace(Referer) == false) req.SetRequestHeader("Referer", Referer);
                if (String.IsNullOrWhiteSpace(cookie) == false) req.SetRequestHeader("Cookie", cookie);
                if (string.IsNullOrWhiteSpace(contentType) == false) req.SetRequestHeader("Content-Type", contentType);
                for(int i = 0; i <= headernames.Count(); i++)
                {
                    if (string.IsNullOrWhiteSpace(headernames[i]) == false && string.IsNullOrWhiteSpace(headers[i]) == false)
                    {
                        req.SetRequestHeader(headernames[i], headers[i]);
                    }
                }
                req.Send(data);
                req.WaitForResponse();
            }
            catch(Exception ex)
            {
                return "Error : " + ex.Message.Trim();
            }

            return req.ResponseText;
        }
    }
}

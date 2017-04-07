using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SetDNS
{
    public static class Helpers
    {
        public static bool IsValidIPAddress(string ip)
        {
            if (string.IsNullOrEmpty(ip)) return false;

            string pattern = @"(?<First>2[0-4]\d|25[0-5]|[01]?\d\d?)\.(?<Second>2[0-4]\d|25[0-5]|[01]?\d\d?)\.(?<Third>2[0-4]\d|25[0-5]|[01]?\d\d?)\.(?<Fourth>2[0-4]\d|25[0-5]|[01]?\d\d?)";

            return Regex.IsMatch(ip.Trim(), pattern);
        }
    }
}

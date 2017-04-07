using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SetDNS
{
    public static class NativeMethods
    {
        [DllImport("dnsapi.dll")]
        public static extern uint DnsFlushResolverCache();
    }
}

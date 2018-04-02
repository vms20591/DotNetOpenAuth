using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetOpenAuth.OAuth2
{
    public class AuthorizationCodeWrapper
    {
        public string AuthorizationCode { get; set; }
        public HashSet<string> Scope { get; set; }
    }
}

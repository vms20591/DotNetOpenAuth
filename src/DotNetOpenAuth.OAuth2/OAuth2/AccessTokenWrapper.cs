using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetOpenAuth.OAuth2
{
    public class AccessTokenWrapper
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ClientIdentifier { get; set; }
        public string User { get; set; }
        public HashSet<string> Scope { get; set; }
        public TimeSpan Lifetime { get; set; }
        public DateTime UtcCreationDate { get; set; }
        public string TokenType { get; set; }
    }
}

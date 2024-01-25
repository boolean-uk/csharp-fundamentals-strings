using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_strings.Main
{
    public class Core
    {
        // A URL consists of these parts: [protocol]://[domain]/[path]
        public string brokenUrl = " httpz://booLeAn.co.uk/who-we-are ";

        //TODO: 1. The brokenUrl member above contains an invalid URL. There's a z instead of an s in the protocol (httpz instead of https).
        // Using the `replace` method on brokenUrl, set the fixedUrl member below to the correct value.
        // https://learn.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-7.0
        public string fixedUrl => brokenUrl.Replace('z', 's');


        // Here's a documentation link for all string methods, use it to figure out how to complete the rest of these requirements:
        // https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0


        //TODO: 2. There are currently some upper case characters in the URL. Using an appropriate string method on the fixedUrl member above,
        // set the value of lowerCasedUrl.
        public string lowerCasedUrl => fixedUrl.ToLower();


        //TODO: 3. There is still white space on both ends of the URL! Use the appropriate string method to trim that white space
        // and set the value of the url member below
        public string url => lowerCasedUrl.Trim();


        //TODO: 4. Using the appropriate string method on url, set the value of the protocol member below
        public string protocol => url.Substring(0, 5);


        //TODO: 5. Using the appropriate string method on url, set the value of the domain member below
        public string domain => url.Substring(protocol.Length + 3, 13);


        //TODO: 6. Set the length member below to the length of the url member
        public int length => url.Length;


        //TODO: 7. Using concatenation and existing members, set the faqUrl member below to the faq page of the boolean website
        public string faqUrl => $"{protocol}://{domain}/faq";
    }
}

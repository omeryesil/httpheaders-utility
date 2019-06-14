using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HttpHeaders_Utility.Controllers
{
    public class UtilityLib
    {

        public string EncodeString(string value)
        {
            return HttpUtility.HtmlDecode(value);
        }
    }
}

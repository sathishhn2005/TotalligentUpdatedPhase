using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Totalligent.Utilities
{
    public class GetAppSettingsValue
    {
        public static string GLEndorsementDocumentPath()
        {
            return ConfigurationManager.AppSettings["GLEndorsementDocumentPath"];                
        }

        public static string EndorsementPath()
        {
            return ConfigurationManager.AppSettings["EndorsementPath"];
        }
    }
}

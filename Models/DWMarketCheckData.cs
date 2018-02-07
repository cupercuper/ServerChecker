using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudBread.Models
{
    [Serializable]
    public class DWMarketCheckInputParam
    {
        public string token;
        public string marketName;
        public string clientVersion;
    }

    [Serializable]
    public class DWMarketCheckModel
    {
        public string serverVersion;
        public byte checkState;
        public byte errorCode;
    }
}
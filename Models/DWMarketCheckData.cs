using System;

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
using ONS.Entities;
using System;

namespace ONS.Exceptions
{
    public class OnsException: ApplicationException
    {
        public RetResult<object> Result { get; set; }

        public string Url { get; set; }
        public OnsException(string message, Exception inner, RetResult<object> result, string url = null)
            : base(message, inner)
        {
            Result = result;
            Url = url;

            //WeixinTrace.ErrorJsonResultExceptionLog(this);
        }

    }
}

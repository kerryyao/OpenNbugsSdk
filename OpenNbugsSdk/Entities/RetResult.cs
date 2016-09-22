using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public interface IJsonResult
    {
        string msg { get; set; }
        object r { get; set; }
        object rs { get; set; }
    }

    public interface IResult : IJsonResult
    {
        ReturnCode code { get; set; }
    }

    [Serializable]
    public class RetResult : IResult
    {
        public ReturnCode code { get; set; }

        public string msg { get; set; }

        public virtual object r { get; set; }

        public virtual object rs { get; set; }
    }
}

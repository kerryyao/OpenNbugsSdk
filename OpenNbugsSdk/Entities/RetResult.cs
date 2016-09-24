using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public class RetResult<T>
    {
        public ReturnCode code { get; set; }

        public string msg { get; set; }

        public T r { get; set; }

        public T rs { get; set; }
    }
}

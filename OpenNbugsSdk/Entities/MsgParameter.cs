using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    /// <summary>
    /// 
    /// </summary>

    public class MsgParameter
    {
        public string msgid { get; set; }

        public string funcid { get; set; }

        public string msgtype { get; set; }

        public string parentsReceive { get; set; }

        public string studentReceive { get; set; }

        public string orgid { get; set; }

        public string senderid { get; set; }

        public string userids { get; set; }

        public string deptids { get; set; }

        public string userroles { get; set; }

        public string exclude_userids { get; set; }

        public string with_subdepts { get; set; }

        public object msg { get; set; }
    }
}

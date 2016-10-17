using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public class Organize
    {
        public string deptName { get; set; }

        public string deptSeq { get; set; }

        public List<SubDepts> subDepts { get; set; }

        public string deptId { get; set; }

        public string deptType { get; set; }

        public string orgId { get; set; }

        public string parentId { get; set; }

       
    }
}

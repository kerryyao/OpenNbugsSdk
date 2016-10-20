using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public class Picture
    {
        public string title { get; set; }

        public string summary { get; set; }

        public string picUrl { get; set; }

        public class link
        {
            public string linkId { get; set; }

            public string urlParams { get; set; }
        }
    }
}

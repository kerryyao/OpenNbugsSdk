using System.Collections.Generic;

namespace ONS.Entities
{
    public class RetResult<T>
    {
        public string code { get; set; }
        public string msg { get; set; }
        public string error { get; set; }

        public string error_description { get; set; }

        public T r { get; set; }

        public List<T> rs { get; set; }
    }
}

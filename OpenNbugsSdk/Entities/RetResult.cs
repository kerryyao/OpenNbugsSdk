using System.Collections.Generic;

namespace ONS.Entities
{
    public class RetResult<T>
    {
        public string error { get; set; }

        public string error_description { get; set; }

        public T r { get; set; }

        public List<T> rs { get; set; }
    }
}

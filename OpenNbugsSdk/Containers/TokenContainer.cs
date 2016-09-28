using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Containers
{
    public static class TokenContainer
    {
        private static MemoryCache cache;

        static TokenContainer()
        {
            var cachename = Guid.NewGuid().ToString("N").Replace("-", "");
            cache = new MemoryCache(cachename);
        }

        /// <summary>
        /// 存入内存中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="model"></param>
        /// <param name="expired"></param>
        public static void setCache<T>(string key, T model, int expired = 24)
        {
            cache.Add(key, model, DateTime.Now.AddHours(expired));
        }

        public static T getCache<T>(string key)
            where T : class
        {
            return cache.Get(key) as T;
        }
    }
}

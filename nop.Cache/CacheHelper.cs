using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.Cache
{
    public class CacheHelper
    {
        public static readonly string _RedisCachingConnectionString =
            ConfigurationManager.AppSettings["RedisCachingConnectionString"];

        private static readonly RedisCacheManager _RedisCacheManager;

        static CacheHelper()
        {
            //创建缓存
            if (!string.IsNullOrWhiteSpace(_RedisCachingConnectionString))
            {
                _RedisCacheManager = new RedisCacheManager(_RedisCachingConnectionString);
            }
        }

        /// <summary>
        ///     创建缓存项的文件
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <param name="obj">object对象</param>
        public static void Insert(string key, object obj)
        {
            Insert(key, obj, 60);
        }

        /// <summary>
        ///     移除缓存项的文件
        /// </summary>
        /// <param name="key">缓存Key</param>
        public static void Remove(string key)
        {
            _RedisCacheManager.Remove(key);
        }

        /// <summary>
        ///     创建缓存项过期
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <param name="obj">object对象</param>
        /// <param name="expires">过期时间(分钟)</param>
        public static void Insert(string key, object obj, int expires)
        {
            _RedisCacheManager.Set(key, obj, expires);
        }

        /// <summary>
        ///     获取缓存对象
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <returns>object对象</returns>
        public static object Get(string key)
        {
            if (string.IsNullOrEmpty(key)) return null;
            return _RedisCacheManager.Get<object>(key);
        }

        /// <summary>
        ///     获取缓存对象
        /// </summary>
        /// <typeparam name="T">T对象</typeparam>
        /// <param name="key">缓存Key</param>
        /// <returns></returns>
        public static T Get<T>(string key)
        {
            return _RedisCacheManager.Get<T>(key);
        }
    }
}

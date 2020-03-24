using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Common
{
    public static class GUIDUtility
    {
        /// <summary>
        /// 16位字母
        /// </summary>
        /// <returns></returns>
        public static string GenerateCharID()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        /// <summary>
        /// 19位数字
        /// </summary>
        /// <returns></returns>
        public static string GenerateNumberID()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0).ToString();
        }
    }
}

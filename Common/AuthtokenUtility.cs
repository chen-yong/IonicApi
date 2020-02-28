using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Common
{
    public class AuthtokenUtility
    {
        private static string crykey = "KEY4AUTH";
        /// <summary>
        /// 生成Token
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timeout">小时</param>
        /// <returns></returns>
        public static string Create<TKey>(TKey id, int timeout)
        {
            return DESUtil.Encode(string.Format("{0}-{1}-{2:yyyyMMddHHmmss}", id, timeout, DateTime.Now), crykey);
        }

        public static TKey GetId<TKey>(string token)
        {
            string uncrystr = DESUtil.Decode(token, crykey);
            return (TKey)Convert.ChangeType(uncrystr.Split('-')[0], typeof(TKey));
        }
        /// <summary>
        /// 验证令牌是否有效
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static bool ValidToken<TKey>(string token)
        {
            try
            {
                string uncrystr = DESUtil.Decode(token, crykey);
                string[] factors = uncrystr.Split('-');
                if (factors.Length == 3)
                {
                    int tmp;
                    if (int.TryParse(factors[1], out tmp))
                    {
                        DateTime createDatetime;
                        if (DateTime.TryParseExact(factors[2], "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out createDatetime))
                        {
                            DateTime endTime = createDatetime.AddHours(tmp);
                            return endTime > DateTime.Now;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static string md5(string org)
        {
            return StringUtils.md5HashString(org);
        }
    }
}

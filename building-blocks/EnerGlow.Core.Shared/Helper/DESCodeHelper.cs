using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnerGlow.Core.Shared.Helper
{
    /// <summary>
    /// 加密解密类：
    /// </summary>
    public static class DESCodeHelper
    {
        // KEY 8位
        private const string CodeKey = "%ENERTY*";
        private static readonly byte[] Keys = { 0xEF, 0xAB, 0x56, 0x78, 0x90, 0x34, 0xCD, 0x12 };

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string EncryptDes(string encryptString)
        {
            return EncryptDes(encryptString, CodeKey);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <returns></returns>
        public static string DecryptDes(string decryptString)
        {
            return DecryptDes(decryptString, CodeKey);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string MD5Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(input);
                var outputBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(outputBytes).Replace("-", "");
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] MD5HashByte(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var outputBytes = md5.ComputeHash(inputBytes);
                return outputBytes;
            }
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA1Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            var sha1 = new SHA1CryptoServiceProvider();
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var outputBytes = sha1.ComputeHash(inputBytes);
            return BitConverter.ToString(outputBytes).Replace("-", "");
        }

        #region 私有方法

        /// <summary>
        /// 对称加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <param name="codeKey"></param>
        /// <returns></returns>
        private static string EncryptDes(string encryptString, string codeKey)
        {
            try
            {
                var rgbKey = Encoding.UTF8.GetBytes(codeKey);
                var rgbIv = Keys;
                var inputByteArray = Encoding.UTF8.GetBytes(encryptString);

                using var des = DES.Create();
                using var mStream = new MemoryStream();
                using var cStream = new CryptoStream(mStream, des.CreateEncryptor(rgbKey, rgbIv), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                var str = Convert.ToBase64String(mStream.ToArray());
                return str;
            }
            catch (Exception)
            {
                return encryptString;
            }
        }

        /// <summary>
        /// 对称解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <param name="codeKey"></param>
        /// <returns></returns>
        private static string DecryptDes(string decryptString, string codeKey)
        {
            try
            {
                var rgbKey = Encoding.UTF8.GetBytes(codeKey);
                var rgbIv = Keys;
                var inputByteArray = Convert.FromBase64String(decryptString);

                using var des = DES.Create();
                using var mStream = new MemoryStream();
                using var cStream = new CryptoStream(mStream, des.CreateDecryptor(rgbKey, rgbIv), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                var str = Encoding.UTF8.GetString(mStream.ToArray());
                return str;
            }
            catch (Exception)
            {
                return decryptString;
            }
        }
        #endregion

    }
}
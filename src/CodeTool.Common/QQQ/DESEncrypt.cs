using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace CodeTool
{
    /// <summary>
    /// DES加密/解密类。
    /// </summary>
    public static class DESEncrypt
    {



        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string EnCode(string Text, string key = "tayasa#@")
        {
          
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            var DD = des.CreateEncryptor(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(key));
            byte[] inputByteArray = Encoding.Default.GetBytes(Text);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(inputByteArray);
            CryptoStream cs = new CryptoStream(ms, DD, CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);

            var SD = inputByteArray.ToString();
            return Convert.ToBase64String(ms.ToArray());
        }
        /// <summary>
        /// 进行DES加密。
        /// </summary>
        /// <param name="pToEncrypt">要加密的字符串。</param>
        /// <param name="sKey">密钥，且必须为8位。</param>
        /// <returns>以Base64格式返回的加密字符串。</returns>
        public static string Encrypt(string pToEncrypt, string sKey = "tayasa#@")
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                return str;
            }
        }


        // <summary>
        // 进行DES解密。
        // </summary>
        // <param name="pToDecrypt">要解密的以Base64</param>
        // <param name="sKey">密钥，且必须为8位。</param>
        // <returns>已解密的字符串。</returns>
        public static string DeCode1(string pToDecrypt, string sKey = "tayasa#@")
        {
            byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return str;
            }
        }



        public static string DeCode(string data, string key = "tayasa#@")
        {

            byte[] buffer;
            string result = string.Empty;
            try
            {
                buffer = Convert.FromBase64String(data);
                DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream stream = new MemoryStream(buffer);
                var transform = dESCryptoServiceProvider.CreateDecryptor(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(key));
                CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
                StreamReader streamReader = new StreamReader(stream2);
                result = streamReader.ReadToEnd();
                return result;
            }
            catch
            {
                return result;
            }

        }



    }
}

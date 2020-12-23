using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TNTTSHOP.Areas.Admin.Data
{
    public class StringProcessing
    {
        public static string CreateMD5Hash(string input)
        {

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashByte = md5.ComputeHash(inputBytes);

            StringBuilder sd = new StringBuilder();
            for (int i = 0; i < hashByte.Length; i++)
            {
                sd.Append(hashByte[i].ToString("X2"));
            }
            return sd.ToString();
        }
    }
}

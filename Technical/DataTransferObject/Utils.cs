using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataTransferObject.Utils
{
    public class Utils
    {
        public static String errorMessage = "Dữ liệu không thể để trống";
        //Chuẩn hóa
        public static string StandStringSpace(string strInput)
        {
            if (strInput.Equals(""))
                return strInput.TrimEnd().TrimStart();
            else
                return strInput;
        }


        /**
         * Ham chuan hoa ten rieng nguoi
         * @param _str
         * @return 
         */
        public static String standardNamePerson(String _str)
        {
            try
            {
                _str = removeSpaceBalance(_str).ToLower();
                String[] temp = _str.Split(new Char[] { ' ' });
                _str = "";
                for (int i = 0; i < temp.Length; i++)
                {
                    _str += temp[i].Substring(0, 1).ToUpper() + temp[i].Substring(1);
                    if (i < temp.Length - 1) // ? ^-^
                        _str += " ";
                }
                return _str;
            }
            catch (Exception ex)
            {
                return _str;
            }
        }
        /**
         * Phuong thuc chuan hoa chuoi viet hoa chu cai dau tien
         * @param _str
         * @return 
         */
        public static String StandardName(String _str)
        {
            try
            {
                _str = removeSpaceBalance(_str);
                _str = _str.Substring(0, 1).ToUpper() + _str.Substring(1, _str.Length - 1);

                return _str;
            }
            catch (Exception ex)
            {
                return _str;
            }
        }
        /**
         * Ham bo cac ky tu trang thua
         * @param _str chuoi nguon
         * @return chuoi dich
         */
        public static String removeSpaceBalance(String _str)
        {
            String temp = _str.Trim();

            temp = Regex.Replace(temp, @"\s+", " ");
            return temp;
        }


        //Hàm mã Hóa MD5
        public static String GetMD5(string strInput)
        {
            StringBuilder strMD5 = new StringBuilder();
            byte[] array = System.Text.Encoding.UTF8.GetBytes(strInput);
            MD5CryptoServiceProvider outMD5 = new MD5CryptoServiceProvider();
            array = outMD5.ComputeHash(array);
            foreach (byte a in array)
            {
                strMD5.Append(a.ToString("x2"));
            }
            return strMD5.ToString();
        }
    }
}

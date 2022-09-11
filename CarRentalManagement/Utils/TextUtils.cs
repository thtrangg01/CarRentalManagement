using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Utils
{
    public class TextUtils
    {
        public static string FormatCurrencyVN(decimal value, bool hasSymbol)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            if (!hasSymbol)
            {
                culture.NumberFormat.CurrencySymbol = String.Empty;
            }
            string result = value.ToString("c", culture);
            return result;
        }

        public static string FormatCurrencyVN(decimal value)
        {
            return FormatCurrencyVN(value, false);
        }

        public static string GenerateId(string prefix, string lastNumber)
        {
            string index = lastNumber.Substring(prefix.Length);
            int key;
            try
            {
                key = Convert.ToInt16(index) + 1;
            }
            catch (Exception)
            {
                key = 1;
            }
            return FormatEntityNumber(key, prefix);
        }

        public static string FormatEntityNumber(int i, string prefix)
        {
            string result;
            if (i < 10)
            {
                result = prefix + "0000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = prefix + "000" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = prefix + "00" + i.ToString().Trim();
            }
            else if (i < 10000)
            {
                result = prefix + "0" + i.ToString().Trim();
            }
            else result = prefix + i.ToString().Trim();
            return result;
        }
    }
}

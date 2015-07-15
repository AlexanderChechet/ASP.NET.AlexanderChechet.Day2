using System;
using System.Globalization;

namespace Task2
{
    public class CustomFormatProvider : ICustomFormatter, IFormatProvider
    {
        private string magicString;

        public CustomFormatProvider()
        {
            magicString = "0123456789ABCDEF";
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof (ICustomFormatter))
                return this;
            return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (!(arg.GetType() == typeof (Int32) || arg.GetType() == typeof (Int64)))
            {
                try
                {
                    HandleOtherFormats(format, arg);
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format("The format of '{0}' is invalid.", format), e);
                }
            }
            if (format == null)
                return HandleOtherFormats(format, arg);

            string ufmt = format.ToUpper(CultureInfo.InvariantCulture);
            
            if (ufmt != "H")
            {
                try
                {
                    return HandleOtherFormats(format, arg);
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format("The format of '{0}' is invalid.", format), e);
                }
            }

            return DecToHex((int)arg);
        }

        public string HandleOtherFormats(string format, object arg)
        {
            if (arg is IFormattable)
            {
                return ((IFormattable) arg).ToString(format, CultureInfo.CurrentCulture);
            }
            else
            {
                if (arg != null)
                {
                    return arg.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string DecToHex(int number)
        {
            string result = "";
            number = Math.Abs(number);
            while (number > 0)
            {
                result = GetChar(number%16) + result;
                number /= 16;
            }
            return result;
        }

        private char GetChar(int rest)
        {
            return magicString[rest];
        }
    }
}

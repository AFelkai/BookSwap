using System;
using Xamarin.Forms;

namespace BookSwap
{
    public class Constants
    {
        public static class Colors
        {
            public static Color placeholderColor = Color.FromHex("A1A1A1");
            public static Color primaryFontColor = Color.FromHex("9013FE");
            public static Color SecondaryFontColor = Color.FromHex("C32AFF");
        }

        public class AWSS3
        {
            public static string bucketName = "comp-490-bookswap";
        }
        public class Strings
        {
            public string pathToImages = "Users/ryan/git repos/";
        }

        public static class FontSizes
        {
            public static int placeholderSize = 12;
            public static int subHeaderSize = 10;
        }
    }
}

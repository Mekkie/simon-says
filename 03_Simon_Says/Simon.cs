using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        public Simon()
        {
        }

        internal static string Echo(string v)
        {
            return v.ToLower();
        }

        internal static string Shout(string v)
        {
            return v.ToUpper();
        }

        internal static string Repeat(string v)
        {
            return v + " " + v;
        }

        internal static object Repeat(string v1, int v2)
        {
            string v = v1;
            for (int i = 1; i < v2; i++)
            {
                v = v + " " + v1;
            }
            return v;
        }

        internal static string StartOfWord(string v1, int v2)
        {
            string v;
            v = v1.Substring(0, v2);
            {
                return v;
            }

        }

        internal static string FirstWord(string v)
        {
            return v.Substring(0, v.IndexOf(" "));
        }

        internal static string Titleize(string v)
        {
            string result = "";
            string RStr;
            int i = 0;
            string[] words = v.Split(' ');

            foreach (string str in words)
            {
                if (i == 0)
                {
                    RStr = char.ToUpper(str[0]) + str.Substring(1);
                    result = result + RStr;
                }
                else
                {
                    if (str != "over" && str != "the" && str != "and")
                    {
                        RStr = char.ToUpper(str[0]) + str.Substring(1);
                        result = result + " " + RStr;
                    }
                    else
                    {
                        result = result + " " + str;
                    }

                }
                i++;
            }

            return result;
        }
    }
    }

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003无重复字符的最长子串
{
    class Program
    {
        //给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

        //示例 1:

        //输入: "abcabcbb"
        //输出: 3 
        //解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
        //示例 2:

        //输入: "bbbbb"
        //输出: 1
        //解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
        //示例 3:

        //输入: "pwwkew"
        //输出: 3
        //解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
        //请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
        static void Main(string[] args)
        {
            string str = " ";
            int length = GetNorepeatStrLength(str);
            Console.WriteLine(length.ToString());
            Console.ReadKey();
        }

        private static int GetNorepeatStrLength(string str)
        {
            List<int> list = new List<int>();
            Hashtable ht = new Hashtable();
            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                list.Add(count);
                ht.Clear();
                ht[i] = str[i];
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (!ht.ContainsValue(str[j]))
                    {
                        ht[j] = str[j];
                        count++;
                        list[i] = count;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (list.Count == 0) return 0;

            return list.Max();
        }
    }
}

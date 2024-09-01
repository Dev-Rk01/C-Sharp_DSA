using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
	public static class PracticeProblems
	{
		public static Dictionary<char, int> countChars(string str)
		{
			Dictionary<char, int> dict = new Dictionary<char, int>();
			
			foreach (char c in str.ToLower())
			{
                if (c >= 'a' && c <= 'z')
				{
					if (dict.ContainsKey(c)) dict[c]++;
					else dict.Add(c, 1);
				}
			}
			return dict;
		}
	}
}

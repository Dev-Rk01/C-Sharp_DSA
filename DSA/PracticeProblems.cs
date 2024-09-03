using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA
{
	public static class PracticeProblems 
	{
		public static Dictionary<char, int> countChar(string str) {
			Dictionary<char, int> dic = new Dictionary<char, int>();
			
			foreach (char c in str) {

				if (isAlphaNumeric(c)) { 
					char lowerCase = char.ToLower(c);
					dic[lowerCase] = dic.ContainsKey(lowerCase) ? dic[lowerCase] + 1 : 1;
				}
			}
			return dic;
		}

		public static bool isAlphaNumeric(char c) {
			return (c >= '0' && c <= '9') || //numeric (0-9)
				   (c >= 'a' && c <= 'z') || //lowercase (a-z)
				   (c >= 'A' && c <= 'Z'); //uppercase (A-Z)
		}

		public static bool isContainSquare(int[] a, int[] b)
		{
			bool flag = false;
			int count = 0;
			if(a.Length != b.Length) return false;
			foreach (int i in a)
			{
				if (b.Contains(i*i)) count++;
			}
			if(count == a.Length) flag = true;
			return flag;
		}
	}
}

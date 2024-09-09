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
		public static Dictionary<char, int> countChar(string str)
		{
			Dictionary<char, int> dic = new Dictionary<char, int>();

			foreach (char c in str)
			{

				if (isAlphaNumeric(c))
				{
					char lowerCase = char.ToLower(c);
					dic[lowerCase] = dic.ContainsKey(lowerCase) ? dic[lowerCase] + 1 : 1;
				}
			}
			return dic;
		}

		public static bool isAlphaNumeric(char c)
		{
			return (c >= '0' && c <= '9') || //numeric (0-9)
				   (c >= 'a' && c <= 'z') || //lowercase (a-z)
				   (c >= 'A' && c <= 'Z'); //uppercase (A-Z)
		}

		public static bool isContainSquare(int[] a, int[] b)
		{
			bool flag = false;
			int count = 0;
			if (a.Length != b.Length) return false;
			foreach (int i in a)
			{
				if (b.Contains(i * i)) count++;
			}
			if (count == a.Length) flag = true;
			return flag;
		}

		public static bool isContainSquareOptimized(int[] a, int[] b)
		{
			if (a.Length != b.Length) return false;
			var bsqCount = new Dictionary<int, int>();
			foreach (int i in b) bsqCount[i] = bsqCount.ContainsKey(i) ? bsqCount[i] + 1 : 1;
			foreach (int num in a)
			{
				int square = num * num;
				if (bsqCount.ContainsKey(square) && bsqCount[square] > 0) bsqCount[square]--;
				else return false;
			}
			return true;
		}

		public static bool IsAnagram(string s1, string s2)
		{
			s1 = s1.ToLower();
			s2 = s2.ToLower();
			s1 = s1.Replace(" ", "");
			s2 = s2.Replace(" ", "");
			if (s1.Length != s2.Length) return false;
			var countFreq = new Dictionary<char, int>();
			foreach (char c in s1) countFreq[c] = countFreq.ContainsKey(c) ? countFreq[c] + 1 : 1;
			foreach (char c in s2)
			{
				if (countFreq.ContainsKey(c) && countFreq[c] > 0) countFreq[c]--;
				else return false;
			}
			return true;
		}

		public static int[] sumZero(int[] arr)
		{
			Array.Sort(arr);
			int start = 0;
            int end = arr.Length - 1;

			while (start < end)
			{
				int sum = arr[start] + arr[end];
				if (sum == 0) return new int[] { arr[start], arr[end] };
				else if (sum > 0) end--;
				else start++;
			}
            return new int[] { };
		}

		public static int uniqueCount(int[] arr)
		{
			//[0, 1, 2, 3, 4, 5, 5, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 9]
			Array.Sort(arr);
			int count = 1;
			int start = 0;
			int next = 1;
			while(next < arr.Length)
			{
				if (arr[start] != arr[next])
				{
					count++;
					start = next;
				}
				next++;
			}
			return count;
		}
	}
}


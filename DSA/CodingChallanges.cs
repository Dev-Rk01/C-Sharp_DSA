using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
	public static class CodingChallanges
	{
		public static bool sameFreq(int num1, int num2)
		{
			string str1 = num1.ToString();
			string str2 = num2.ToString();

			if(str1.Length != str2.Length)
			{
				return false;
			}

			Dictionary<char, int> freqCount = new Dictionary<char, int>();

			foreach(char digit in str1)
			{
				if(freqCount.ContainsKey(digit))
				{
					freqCount[digit]++;
				}
				else
				{
					freqCount[digit] = 1;
				}
			}

			foreach(char digit in str2)
			{
				if(!freqCount.ContainsKey(digit) || freqCount[digit] == 0)
				{
					return false;
				}
				freqCount[digit]--;
			}
			return true;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
	public static class SimpleProblems
	{
		public static int countDigit(int n)
		{
			if (n == 0) return 1;

			int count = 0;
			while (n > 0)
			{
				n = n / 10;
				count++;
			}
			return count;
		}

		public static string palindrome(int n)
		{
			if (n >= 0 && n < 10) return "Enter a two digit number";

			int rem = 0, rev = 0;
            int temp = n;

			while(temp>0)
			{
				rem = temp % 10;
				temp = temp / 10;
				rev = rev * 10 + rem;
			}
			if(rev == n) return "Palindrome";
			return "Not Palindrome";
		}
	}
}

using DSA;
using System.Text;

Console.WriteLine($"Number of digits in 34 -> {SimpleProblems.countDigit(34)}\n");
Console.WriteLine($"Is 212 is Palindrome -> {SimpleProblems.palindrome(212)}\n");
Console.WriteLine($"{5+2} term of fibonacii series  -> {SimpleProblems.fibonacci(5)}\n");
Console.WriteLine($"Factorial of 5 -> {SimpleProblems.factorial(5)}\n");
Console.WriteLine($"Factorial of 5 by recursion -> {SimpleProblems.facorialByRecursion(5)}\n");
Console.WriteLine($"Number of traling zeros in factorial(Overflow Issue for larger numbers) of 20 -> {SimpleProblems.countTrailingZerosInFactorial(20)}\n");
Console.WriteLine($"Number of traling zeros in factorial(Optimized) of 20 -> {SimpleProblems.countTrailingZerosInFactorialOptimized(20)}\n");
Console.WriteLine($"Number of traling zeros in factorial(Optimized_Method-2) of 2515 -> {SimpleProblems.countTrailingZerosInFactorialOptimized_MethodTwo(251)}\n");
Console.WriteLine($"HCF of (100, 250) -> {SimpleProblems.hcfOfTwoNumbers(100,250)}\n");
Console.WriteLine($"HCF of (100, 250) -> {SimpleProblems.hcfOfTwoNumbersOptmized(100,250)}\n");
Console.WriteLine($"HCF of (100, 250) -> {SimpleProblems.hcfOfTwoNumbersFurtherOptmized(100,250)}\n");
Console.WriteLine($"LCM of (100, 250) -> {SimpleProblems.lcmOfTwoNumbers(100,250)}\n");
Console.WriteLine($"LCM of (100, 250) -> {SimpleProblems.lcmOfTwoNumbersOptimized(100,250)}\n");
Console.WriteLine($"Given number is prime -> {SimpleProblems.isPrime(20)}\n");
Console.WriteLine($"Given number is prime -> {SimpleProblems.isPrimeOptimized(20)}\n");
Console.WriteLine($"Given number is prime -> {SimpleProblems.isPrimeFurtherOptimized(20)}\n");
Console.WriteLine($"The prime factor of given number -> {SimpleProblems.primeFactor(20)}\n");
Console.WriteLine($"The prime factor of given number -> {SimpleProblems.primeFactor(20)}\n");

//countChars function call
Dictionary<char, int> dict = PracticeProblems.countChar("Hello i chro  1     2345 $# %(*&%&@");
StringBuilder sb = new StringBuilder();
foreach(KeyValuePair<char, int> item in dict)
{
	sb.Append($"{item.Key}:{item.Value}\n");
	//Console.WriteLine($"{item.Key}:{item.Value}");
};
Console.WriteLine($"Count of each character in string -> \n{sb.ToString()}\n");


Console.WriteLine($"Second array contains all the square of first array -> {PracticeProblems.isContainSquare([5,2,4], [4, 16, 25])}\n");
Console.WriteLine($"Second array contains all the square of first array -> {PracticeProblems.isContainSquareOptimized([5,2,4], [4, 16, 25])}\n");
Console.WriteLine($"Both strings are anagram of each other -> {PracticeProblems.IsAnagram("abcdeefsgh","abcadaefgh")}\n");

int[] a = PracticeProblems.sumZero([-4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
StringBuilder sumZero = new StringBuilder();
foreach(int item in a)
{
	sumZero.Append(item + ",");
}
Console.WriteLine($"Sum Zero -> {sumZero.ToString()}\n");


int countNew = PracticeProblems.uniqueCount([0, 1, 2, 3, 4, 5, 5, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 9]);
Console.WriteLine($"Unique Count -> {countNew}\n");

int maxSum = PracticeProblems.maxSum([1, 2, 5, 2, 8, 1, 5],4);
Console.WriteLine($"Max Sum -> {maxSum}\n");
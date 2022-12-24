using System;
using System.Linq;

Problem object1 = new Problem();
string result = object1.ReverseAndNot(123);
Console.WriteLine(result); 

class Problem
{
    public string ReverseAndNot(int number) 
    {
    // Concat means concatenate = birleştirmek
    // string.Concat method allows you to concatenate two or more strings into a single string. 
    // string s = string.Concat(s1, s2);
    // fstring in c# 
    // string s = $"The square of x is {x * x}"; or string s = string.Format("The value of x is {0}", x);
		return $"{String.Concat(number.ToString().Reverse())}{number}"; 
	}
}
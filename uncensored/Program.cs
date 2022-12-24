using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

Problem myObject = new Problem();

var result = myObject.uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo");

Console.WriteLine(result);


class Problem
{
    public string uncensor(string sentence, string vowels)
    {   
        var sentence_array = sentence.ToCharArray();
        for(int i = 0, j = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == '*')
            {
                sentence_array[i] = vowels[j];
                j++;
            }
        }
        return new string(sentence_array);
    }
}
/*          easier way
	public static string Uncensor(string txt, string vowels)
    {
            foreach(char x in vowels){
                int y = txt.IndexOf('*');
                txt = txt.Remove(y,1).Insert(y,x.ToString());
            }
            return txt.ToString();
	}
    */
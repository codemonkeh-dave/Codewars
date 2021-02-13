using System;
using System.Text;
using System.Collections.Generic;

public class Accumul 
{
	public static String Accum(string s) 
  {
    var letters = s.ToCharArray();
    var outputLetters = new List<string>();
    for (int i=0;i<letters.Length;i++)
    {
      outputLetters.Add(Capitalise(MultiplyChar(letters[i],i+1)));
    }
    return String.Join('-',outputLetters);
  }

  public static string MultiplyChar(char c, int count)
  {
    Console.WriteLine(count);
    StringBuilder sb = new StringBuilder();
    for(int i=1;i<=count;i++)
    {
      sb.Append(c);
    }
    Console.WriteLine(sb.ToString());
    return sb.ToString();
  }

  public static string Capitalise(string s)
  {
    if (s.Length==1)
      return s.ToUpper();
      
    s = s.ToLower();
    var startLetter = s[0];
    s = s.Remove(0,1);
    s = Convert.ToChar(s[0].ToString().ToUpper()) + s;
    return s;
  }
}
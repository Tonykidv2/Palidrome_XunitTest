using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PalidromeApp.Src
{
    public class Palidrome
    {
      public bool isPalidrome(string _word)
      {
        //Making sure all characters are lowercase
        string lower = _word.ToLower();

        //Reverse string using Array.Reverse
        char[] Rarr = lower.ToCharArray();
        Array.Reverse(Rarr);
        
        return lower == new string(Rarr);
      }

      public bool isPhrasePalidrome(string _phrase)
      {
        
        //Removing white Spaces in string
        string remove = " ";
        string lower = Regex.Replace(_phrase.ToLower(), remove, String.Empty);

        //Using earlier function
        return isPalidrome(lower);
      }

      private string RemoveSpecialCharacters(string _word)
      {
        
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < _word.Length; i++)
        {
          if(char.IsLetterOrDigit(_word[i]))
          {
            if(char.IsLetter(_word[i]))
              sb.Append(_word[i]);
          }
        }

        return sb.ToString();
      }
    }
    
}

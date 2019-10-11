using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace ConcatenatingStrings
{
    class Concatenate
    {
        static void Main(string[] args)
        {
            string str1 = "aaabbbccdeeedaaa,.#$@!dd@ds#ss34s1w2!";              //  sample string 1
            string str2 = "waseewr!@ASGEQdaWa";                                 //  sample string 2
            string str3 = "?12#?!sd3java";                                      //  sample string 3
            string concat_string = String.Concat(str1, str2, str3); //.ToLower();   //  concatenating and setting to lower case

            var unique_hash_set = new HashSet<char>(concat_string);             //  using hash set to remove dublicates
            string unique_concat_string = string.Join("", unique_hash_set);     //  converting back to string

            // removing all non-alphabetic symbol using Regex
            string letters_only_string = Regex.Replace(unique_concat_string, @"[^A-Za-z]", @""); 
            Console.WriteLine("Sample strings are: \n\t{0}, \n\t{1}, \n\t{2} \n\nAnd result is: \n\t{3}", str1, str2, str3, letters_only_string);

        }
    }
}



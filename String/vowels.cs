// Problem Statement: Remove Vowels from a String

// You are given a string s consisting of lowercase and uppercase English letters.

// Write a function removeVowels that takes a string as input and returns a new string with all the vowels removed. The vowels are defined as 'a', 'e', 'i', 'o', and 'u', both in lowercase and uppercase.


public class Solution{
    public string RemoveVowels(string s)
    {
        HashSet<char> vowels = new HashSet<char>("aeiouAEIOU");
        StringBuilder result = new StringBuilder();

        foreach(char c in s)
        {
            if(!vowels.Contain(c))
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
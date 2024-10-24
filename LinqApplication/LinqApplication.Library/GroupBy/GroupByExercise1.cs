namespace LinqApplication.LinqApplication.Library.GroupBy
{
    /*
     Implement the GetTheMostFrequentCharacter method, which given a string will return the character that occurs most frequently in this string.
        If the string is null or empty, the result shall be null.
        If more than one character occurs most frequently, the one that occurs first in the word should be returned.
        It doesn't matter if a character is upper case or lower case. The result shall always be lower case.
    For example:
        the result shall be 's' for the word "grass".
        the result shall be 't' for the word "Toast'. Please note that we treat both 'T' and 't' as the same character, and we return the lower case letter.
        the result shall be 'b' for the word "Bumblebee". There are 3 letters 'b' and 3 letters 'e' in this word, but we return 'b' because its first occurrence is before the first occurrence of the letter 'e'
        the result shall be null for the word "" (an empty string)
     */
    public class GroupByExercise1
    {
        public char? GetTheMostFrequentCharacter(string text)
        {
            return !string.IsNullOrEmpty(text) ? 
                   text.ToLower()
                       .GroupBy(ch => ch)
                       .OrderByDescending(ch => ch.Count())
                       .First()
                       .Key : (char?)null;
        }
    }
}

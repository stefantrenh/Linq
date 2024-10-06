namespace LinqApplication.LinqApplication.Library.ConcatAndUnion
{
    /*
     Implement the CleanWord method, which given a string that can consist of letters and non-letter characters, will return a new string, where all letters proceed the non-letter characters. 
     The non-letter characters should be unique in the result.
        For example:
        for input "f_o!_!x" the result will be "fox_!". Please note that only the first "!" is present in the result according to this rule "The non-letter characters should be unique in the result."
        for input "d_3uc(k))" the result will be "duck_3()". Please note that only the first ")" is present in the result according to this rule "The non-letter characters should be unique in the result."
     */
    public class ConcatAndUnionExcercise2
    {
        public static string CleanWord(string word)
        {
            var charArray = word.ToCharArray();

            return new string(
                charArray.Where(character => char.IsLetter(character))
                         .Concat(charArray.Where(character => !char.IsLetter(character)).Distinct())
                         .ToArray());
        }
    }
}

namespace LinqApplication.LinqApplication.Library.PrependAndAppend
{
    public class PrependAndAppendExcercise1
    {

        /*
         Using LINQ, implement the AddStartAndEndMarkers which given a collection of words, 
         will add "START" at the beginning and "END" at the end, unless those markers were already present.

            For example:            
                For input {"AAA", "BBB"} the result shall be {"START", "AAA", "BBB", "END"}        
                For input {"START", "AAA", "BBB"} the result shall be {"START", "AAA", "BBB", "END"}       
                For input {"AAA", "BBB", "END"} the result shall be {"START", "AAA", "BBB", "END"}
                For input {"START", "AAA", "BBB", "END"} the result shall be {"START", "AAA", "BBB", "END"}
            
            We don't care if words "START" and "END" are anywhere else in the collection.      

            For example:        
                For input {"AAA", "START",  "END", "BBB",  "START"} the result shall be {"START", "AAA", "START",  "END", "BBB",  "START", "END"}
         */
        public static IEnumerable<string> AddStartAndEndMarkers(IEnumerable<string> words)
        {
            const string Start = "START";
            const string End = "END";

            var withStart = words.First() == Start ? words : words.Prepend(Start);

            return withStart.Last() == End ? withStart : withStart.Append(End);
        }
    }
}

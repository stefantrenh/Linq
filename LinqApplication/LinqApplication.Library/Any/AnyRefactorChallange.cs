namespace LinqApplication.LinqApplication.Library.Any
{
    internal class AnyRefactorChallange
    {
        //TODO implement this method
        public static bool AreAllNamesValid_Refactored(string[] names)
        {
            return !names.Any(
                x => char.IsLower(x[0]) ||
                x.Length < 2 ||
                x.Length > 25
                );
        }

        //do not modify this method
        public static bool AreAllNamesValid(string[] names)
        {
            foreach (var name in names)
            {
                if (char.IsLower(name[0]))
                {
                    return false;
                }
                if (name.Length < 2)
                {
                    return false;
                }
                if (name.Length > 25)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

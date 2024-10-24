﻿namespace LinqApplication.LinqApplication.Library.GroupBy
{
    internal class GroupByRefactoringChallange
    {
        //TODO implement this method
        public static IEnumerable<string> CountPets_Refactored(string petsData)
        {
            return !string.IsNullOrEmpty(petsData) ? 
                petsData.Split(',')
                        .GroupBy(word => word)
                        .Select(group => $"{group.Key}:{group.Count()}")
                : new string[0]; 
        }

        //do not modify this method
        public static IEnumerable<string> CountPets(string petsData)
        {
            if (string.IsNullOrEmpty(petsData))
            {
                return new string[0];
            }
            var pets = petsData.Split(',');
            var petsCountsDictionary = new Dictionary<string, int>();
            foreach (var pet in pets)
            {
                if (!petsCountsDictionary.ContainsKey(pet))
                {
                    petsCountsDictionary[pet] = 0;
                }
                petsCountsDictionary[pet]++;
            }
            var result = new List<string>();
            foreach (var petCount in petsCountsDictionary)
            {
                result.Add($"{petCount.Key}:{petCount.Value}");
            }
            return result;
        }
    }
}

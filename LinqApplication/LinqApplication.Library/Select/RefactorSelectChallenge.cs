namespace LinqApplication.LinqApplication.Library.Select
{
    internal class RefactorSelectChallenge
    {
        //TODO implement this method
        public static TimeSpan TotalDurationOfSongs_Refactored(string allSongsDuration)
        {
            return string.IsNullOrEmpty(allSongsDuration) ?
                          new TimeSpan() : TimeSpan.FromSeconds(allSongsDuration.Split(",")
                                                                .Select(duration => TimeSpan.ParseExact(
                                                                        duration, @"m\:ss", null))
                                                                .Sum(timeSpan => timeSpan.TotalSeconds));
        }

        //do not modify this method
        public static TimeSpan TotalDurationOfSongs(
            string allSongsDuration)
        {
            if (string.IsNullOrEmpty(allSongsDuration))
            {
                return new TimeSpan();
            }

            var durationStrings = allSongsDuration.Split(',');
            var totalDuration = 0d;
            foreach (var durationString in durationStrings)
            {
                var timeSpan = TimeSpan.ParseExact(
                    durationString, @"m\:ss", null);
                totalDuration += timeSpan.TotalSeconds;
            }

            return TimeSpan.FromSeconds(totalDuration);
        }
    }
}

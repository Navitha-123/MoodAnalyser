namespace MoodAnalyser
{
    internal static class UC3MoodAnalyserHelpers
    {

        public static string AnalyseMood(string message)
        {
            try
            {
                if (message == null)
                {
                    throw (new MoodAnalysisException("Null mood"));
                }
                else
                {
                    throw (new MoodAnalysisException("Empty Mood"));
                }
            }
            catch (MoodAnalysisException ex)
            {
                rerurn message;
            }
        }
    }
}
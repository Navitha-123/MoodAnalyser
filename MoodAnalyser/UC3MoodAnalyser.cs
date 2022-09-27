using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class UC3MoodAnalyser
    {
        public string message;
        public class MoodAnalysisException : Exception
        {
            public MoodAnalysisException(string msg) : base(msg)
            {

            }
        }                        
        public string AnalyseMood(string message)
        {
            try
            {
                if (message == null)
                {
                    throw (new MoodAnalysisException("Null Mood"));
                }
                else
                {
                    throw (new MoodAnalysisException("Empty Mood"));
                }
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }

      
    }
}

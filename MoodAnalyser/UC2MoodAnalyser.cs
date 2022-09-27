using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class UC2MoodAnalyser
    {

        public string message;
        public string MoodAnalyse(string message)
        {
            try
            {
                message = message.ToLower();
                if (message.Contains("happy"))
                {
                    return "happy";

                }
                else
                {
                    return "sad";
                }
            }
            catch (Exception ex)
            {
                return "happy";
            }
        }
    }
}

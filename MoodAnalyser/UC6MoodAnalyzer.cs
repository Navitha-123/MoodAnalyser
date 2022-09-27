using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.UC3MoodAnalyser;

namespace MoodAnalyser
{
    public class UC6MoodAnalyzer
    {
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] {typeof(string)});
                    object instance = ctor.Invoke(new object[] {message});  
                    return instance;
                }

                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }

            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "class is not found");
            }
        }

        public static string InvokeAnalysisMood(string message,string MethodName)
        {
            try
            {
                Type type = Type.GetType(MoodAnalyserProblem.MoodAnalyser);
                object moodAnalyseObject = MoodAnalyserFactoryUCSix.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo analyseMoodInfo = type.GetMethod(MethodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
            }
        }
    }
}

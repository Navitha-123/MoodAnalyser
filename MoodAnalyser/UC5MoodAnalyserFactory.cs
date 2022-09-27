using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.UC3MoodAnalyser;


namespace MoodAnalyser
{
    public class UC5MoodAnalyserFactory
    {
       



        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(UC4MoodAnalyser);

            if(type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor((Type[])new object[] {message});
                    return ctor.Invoke(null);
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
    }
}

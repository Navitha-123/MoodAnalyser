using MoodAnalyser;
using System.Runtime.CompilerServices;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MessgeUC1T1()
        {
            string msg = "I am in sad mood";
            string expected = "sad";

            //Act
            UC1HappyOrSad analysemood = new UC1HappyOrSad();
            string actual = analysemood.AnalyseMood(msg);

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void MessgeUC2T2()
        {
            string msg = "I am in happy mood";
            string expected = "happy";

            //Act
            UC2MoodAnalyser analysemood = new UC2MoodAnalyser();
            string actual = analysemood.MoodAnalyse(msg);

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void MessgeUC3T3()
        {
            string msg = "I am in null mood";
            string expected = "null";

            //Act
            UC3MoodAnalyser analysemood = new UC3MoodAnalyser();
            string actual = analysemood.AnalyseMood(msg);

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void MessgeUC33T()
        {
            string msg = "I am in empty mood";
            string expected = "empty";

            //Act
            UC3MoodAnalyser analysemood = new UC3MoodAnalyser();
            string actual = analysemood.AnalyseMood(msg);

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {

            object expected = new UC4MoodAnalyser();
            object obj = MoodAnalyserFactoryUC4.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyserUCOne", "MoodAnalyserUCOne");
            expected.Equals(obj);


        }

        [TestMethod]
        public void GivenMoodAnalyserClassName()
        {

            object expected = new UC5MoodAnalyserFactory("happy");
            object obj = MoodAnalyserFactoryUC5.CreateMoodAnalyseusingParametrizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser","happy");
            expected.Equals(obj);


        }

        [TestMethod]

        public void GivenHappyShouldReturnHappy()
        {
            object expected = "happy";
            string mood = MoodAnalyserFactoryUC6.InvokeAnalyseMood("happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
            Console.WriteLine(mood);
        }
    }
}
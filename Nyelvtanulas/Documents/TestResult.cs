using System;

namespace Nyelvtanulas.Documents
{
    public class TestResult
    {
        public readonly DateTime Date;
        public readonly int Percentage;
        internal readonly string SecondLanguage;
        internal readonly string FirstLanguage;

        public TestResult(DateTime date, int percentage,string firstLanguage,string secondLanguage)
        {
            Date = date;
            Percentage = percentage;
            FirstLanguage = firstLanguage;
            SecondLanguage = secondLanguage;
        }
    }
}
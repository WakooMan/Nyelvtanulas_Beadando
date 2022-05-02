using System;

namespace Nyelvtanulas.Documents
{
    public class TestResult
    {
        public readonly DateTime Date;
        public readonly int Percentage;

        public TestResult(DateTime date, int percentage)
        {
            Date = date;
            Percentage = percentage;
        }
    }
}
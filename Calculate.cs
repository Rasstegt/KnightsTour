using System;

namespace KnightsTour
{
    
    class Calculate
    {
        public int Run { get; set; }
        public int CurrentSteps { get; set; }
        public int TotalRuns { get; set; }
        public int StepSum { get { return Total; } set { Total += value; } }
        public int Total { get; set; }

        public Calculate()
        {

        }

        public int getAverage()
        {
            return StepSum / Run;
        }

        public string getDeviation()
        {
            double sumOfDifference = 0;
            double mean = StepSum / Run;    // using Run (current) so I can track the deviation after each run
            double[] difference = new double[TotalRuns];
            for(int i = 0; i < difference.Length; i++)
            {
                difference[i] = CurrentSteps - mean;
                difference[i] = difference[i] * difference[i];
                sumOfDifference += difference[i];
            }
            double variance = sumOfDifference / Run;
            return String.Format("{0:0.00}", Math.Sqrt(variance));

        }

        public string getTourDetails()
        {
            return String.Format("Tour {0}: Knight was able to do {1} steps.", Run, CurrentSteps);
        }

        public void ResetTour()
        {
            Run = 0;
            Total = 0;
            TotalRuns = 0; 
            CurrentSteps = 0;
        }

    }
}

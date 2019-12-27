using System;
using MLSentimentAnalysisML.Model;

namespace MLSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Review Sentiment Analysis!");
            Console.WriteLine("******");
            Console.Write("Please enter your review:");
            // Add input data
            var input = new ModelInput();
            input.Comment = Console.ReadLine();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            if (result.Prediction.Equals(true))
            {
                Console.WriteLine("Your review sounds negative. Apologies, we will work on making things better for next time!");
            }
            else {
                Console.WriteLine("Your review sounds positive. Glad you enjoyed it!");
            }


        }
    }
}

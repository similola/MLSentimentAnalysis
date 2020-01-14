# ML Sentiment Analysis

A simple C# program that uses a trained ML Model using ML.NET Model Builder to predict sentiment of reviews.

## Project goals

The aim of this project was to build a simple machine learning model for sentiment analysis. Essentially sentiment analysis allows us to understand and classify the sentiment on text.

Using a sample dataset of comments, I used *Binary Classification* to give a sentiment label to each comment. This algorithm of Binary classification is to classify items into one of two classes, in this case the sentiment label is: 
* 0 (nice/positive)
or
* 1 (toxic/negative)

## Project approach
I divided the project into 4 steps: 
1. Build Model
2. Train Model
3. Evaluate Model
4. Consume Model

# Building and Training model
Essentially the input is each comment and the ouput is the sentiment label (what I am trying to predict). I installed Model Builder in Visual Studio (lauched by adding Machine Learning to the Console App). Following this I completed this setp 
* Selected the Scenario:Sentiment Analysis
* Added my input data(a .tsv file) and verified contents in the Data preview file.
* Selected my column to predict (Sentiment label)
* Trained my model by selecting the time to train (Model builder actually selects the algorithm to use based on training time which is pretty cool)

#Evaluating model
Model builder shows you the evaluation of your model. It shows you the best model selected based on your training time, the number of models explored and the the model accuracy(%).

#Consuming model
Model builder also outputs the code to use to consume the model! It adds a console app contianer ModelBuilder.cs which shows how the model was trained(incase I want to retrain later) and also gives you the model as a zip file. After this you can write some simple code to consume your model and try it out on sample data. See below

```csharp
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
```

## How to run this project
1. Clone respository on your local drive.
2. Run program.cs in Visual Studio.
3. Enter your review in the console window when prompted->click enter.

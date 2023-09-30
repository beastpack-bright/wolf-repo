using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ThreeQuestions
{
    internal class Program
    {
        static List<Question> questions = new List<Question>
        {
            new Question("What is your favorite color?", "black"),
            new Question("What is the answer to life, the universe, and everything?", "42"),
            new Question("What is the airspeed velocity of an unladen swallow?", "What do you mean? African or European swallow?")
        };

        static void Main(string[] args)
        {
            do
            {
                PlayQuiz();
                Console.Write("Do you want to play again? (yes/no): ");
            } while (Console.ReadLine().ToLower() == "yes");
        }

        static void PlayQuiz()
        {
            Console.WriteLine("Choose a question (1-3)");

            bool acceptValue = false;
            while (!acceptValue)
            {
                try
                {
                    acceptValue = true;
                    int selectedQuestionIndex = int.Parse(Console.ReadLine()) - 1;

                    if (selectedQuestionIndex >= 0 && selectedQuestionIndex < questions.Count)
                    {
                        Question selectedQuestion = questions[selectedQuestionIndex];

                        Console.WriteLine(selectedQuestion.Text);
                        Console.WriteLine("You have 5 seconds to answer.");
                        Console.Write("Your answer: ");

                        // Flag to track if the timer has expired
                        bool timerExpired = false;

                        var timer = new Timer(TimerCallback, null, 5000, Timeout.Infinite);

                        string userAnswer = Console.ReadLine();

                        timer.Dispose(); // Stop the timer
                        timerExpired = true; // Set the flag to true

                        if (!timerExpired) // Check the flag
                        {
                            if (selectedQuestion.Answer.Any(answer => userAnswer.ToLower() == answer.ToLower()))
                            {
                                Console.WriteLine("Well done!");
                            }
                            else
                            {
                                Console.WriteLine("No. The correct answer(s) is: " + string.Join(", ", selectedQuestion.Answer));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Out of time. The correct answer(s) is: " + string.Join(", ", selectedQuestion.Answer));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a permitted value.");
                }
            }
        }

        static void TimerCallback(object state)
        {
          
            Console.WriteLine("Out of time.");

        }

        class Question
        {
            public string Text { get; }
            public List<string> Answer { get; } = new List<string>();

            public Question(string text, params string[] correctAnswers)
            {
                Text = text;
                Answer.AddRange(correctAnswers);
            }
        }
    }
}

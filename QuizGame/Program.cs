using System;

class QuizGame
{
    static void Main()
    {
        int score = 0;
        string[] questions = { "What is the capital of France?", "What is the largest planet in our solar system?", "Who painted the Mona Lisa?" };
        string[] answers = { "Paris", "Jupiter", "Leonardo da Vinci" };
        string[] options = { "Paris, Marseille, Lyon", "Jupiter, Saturn, Mars", "Leonardo da Vinci, Michelangelo, Raphael" };

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine(options[i]);
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == answers[i].ToLower())
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is " + answers[i]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Quiz complete. Your score is " + score + " out of " + questions.Length);
    }
}

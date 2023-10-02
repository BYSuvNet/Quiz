using System.Text.Json;

class Program
{
    static void Main()
    {
        QuestionsManager questionsManager = new("questions.json");

        Console.WriteLine("Välkommen till Quizet!");
        Console.WriteLine($"Det består av {questionsManager.NumberOfQuestions} frågor och maxpoängen är {questionsManager.MaxPoints} poäng");

        while (true)
        {
            List<Question> failedQuestions = new();

            int poäng = 0;

            foreach (Question fråga in questionsManager.GetAllQuestions())
            {
                int pointsForQuestion = AskQuestions(fråga);
                if (pointsForQuestion == 0)
                {
                    failedQuestions.Add(fråga);
                }
                else
                {
                    poäng += pointsForQuestion;
                }
            }

            Console.WriteLine($"Nu är quizet klart. Du fick {poäng} av max {questionsManager.MaxPoints} poäng.");
            Console.WriteLine($"Du missade {failedQuestions.Count} frågor.");
            Console.WriteLine("Vill du göra om quizet? (j/n)");

            if (Console.ReadLine() == "n")
            {
                break;
            }
        }

        Console.WriteLine("Tack för ditt quizzande!");
    }

    static int AskQuestions(Question question)
    {
        Console.WriteLine(question.Text);

        if (question.CheckAnswer(Console.ReadLine()))
        {
            Console.WriteLine("Rätt!");
            return question.Points;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är: " + question.Answer);
        }

        return 0;
    }

}
class Program
{
    static void Main()
    {
        List<Question> questions = JsonSerializer.Deserialize<List<Question>>(File.ReadAllText("questions.json"));

        int maxPoints = 0;
        foreach (Question item in questions)
        {
            maxPoints += item.Points;
        }

        Console.WriteLine("Välkommen till Quizet!");
        Console.WriteLine($"Det består av {questions.Count} frågor och maxpoängen är {maxPoints} poäng");

        while (true)
        {
            List<Question> failedQuestions = new();

            int poäng = 0;

            foreach (Question fråga in questions)
            {
                int pointsForQuestion = AskQuestions(fråga.Text, fråga.Answer, fråga.Points);
                if (pointsForQuestion == 0)
                {
                    failedQuestions.Add(fråga);
                }
                else
                {
                    poäng += pointsForQuestion;
                }
            }

            Console.WriteLine($"Nu är quizet klart. Du fick {poäng} av max {maxPoints} poäng.");
            Console.WriteLine($"Du missade {failedQuestions.Count} frågor.");
            Console.WriteLine("Vill du göra om quizet? (j/n)");

            if (Console.ReadLine() == "n")
            {
                break;
            }
        }

        Console.WriteLine("Tack för ditt quizzande!");
    }

    static int AskQuestions(string fråga, string svaretPåFrågan, int poäng = 1)
    {
        Console.WriteLine(fråga);

        string svar = Console.ReadLine().ToLower();

        if (svar == svaretPåFrågan.ToLower())
        {
            Console.WriteLine("Rätt!");
            return poäng;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        return 0;
    }

}
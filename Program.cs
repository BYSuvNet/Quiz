﻿class Program
{

    static void Main()
    {
        int poäng = 0;

        Console.WriteLine("Välkommen till Quizet!");

        poäng += AskQuestions("Vilken är huvudstaden i Frankrike?", "paris");
        poäng += AskQuestions("Vilken brukar kallas för den röda planeten?", "mars");
        poäng += AskQuestions("Vilken hundras är Lassie?", "collie", 3);
        poäng += AskQuestions("Vad heter er lärare i OOP?", "gus");

        Console.WriteLine("Nu är quizet klart. Du fick " + poäng + " poäng");
    }

    static int AskQuestions(string fråga, string svaretPåFrågan, int poäng = 1)
    {
        Console.WriteLine(fråga);

        string svar = Console.ReadLine();

        if (svar == svaretPåFrågan)
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

// Välkommen till Quizet!
// Första frågan: Vilken är huvudstaden i Frankrike?
// Svar: paris
// Rätt! 1 poäng!
// Andra frågan: Vilken brukar kallas för den röda planeten?
// Svar: jupiter
// Fel! Rätt svar är Mars. 
// ...
// Nu är quizet klart, du fick 17 poäng. 
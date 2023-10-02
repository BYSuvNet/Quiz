class Program
{
    static void Main()
    {
        QuestionsManager questionsManager = new("questions.json");
        QuestionsUI ui = new(questionsManager);
        ui.Run();
    }
}
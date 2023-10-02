using System.Text.Json;

class QuestionsManager
{
    public int MaxPoints { get => questions.Sum(q => q.Points); }
    public int NumberOfQuestions { get => questions.Count; }

    List<Question> questions = new();

    public QuestionsManager(string pathToJson)
    {
        string json = File.ReadAllText(pathToJson);
        questions = JsonSerializer.Deserialize<List<Question>>(json);
    }

    public Question GetRandomQuestion()
    {
        return questions[new Random().Next(0, questions.Count)];
    }

    public IReadOnlyList<Question> GetAllQuestions()
    {
        return questions.AsReadOnly();
    }
}
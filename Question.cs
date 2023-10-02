
class Question
{
    public string Text { get; private set; }
    public string Answer { get; private set; }
    public int Points { get; private set; }

    public Question(string text, string answer, int points = 1)
    {
        Text = text;
        Answer = answer;
        Points = points;
    }

    public bool CheckAnswer(string svar)
    {
        return svar.ToLower() == Answer.ToLower();
    }
}
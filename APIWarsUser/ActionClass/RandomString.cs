namespace APIWarsUser.ActionClass
{
    public class RandomString
    {
        private int _countWord;
        public RandomString(int count) => _countWord = count;
        public string GenerationWord() => 
            new string((from vybor in Enumerable
                .Repeat("QqWw1EeRr2TtYy3UuIi4OoPp5AaSs6DdFf7GgHhJj8KkLlZz9XxCcVv0BbNnMm", _countWord) 
                select vybor[new Random().Next(vybor.Length)])
                .ToArray());
        
    }
}

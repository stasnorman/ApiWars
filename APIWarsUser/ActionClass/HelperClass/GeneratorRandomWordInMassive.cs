namespace APIWarsUser.ActionClass.HelperClass
{
    public class GeneratorRandomWordInMassive
    {
        private readonly Random magic = new Random();

        /// <summary>
        /// Массив слов, элементов и данных
        /// </summary>
        private string[] MassiveName { get; set; }

        public GeneratorRandomWordInMassive(string[] massiveName)
        {
            MassiveName = massiveName;
        }

        public string GetData() { 
            return MassiveName[magic.Next(0, MassiveName.Length-1)]; 
        }
    }
}

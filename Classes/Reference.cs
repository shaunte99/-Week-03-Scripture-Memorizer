namespace ScriptureMemorizer.Classes
{
    public class Reference
    {
        private string _book;
        private string _verse;

        public Reference(string book, string verse)
        {
            _book = book;
            _verse = verse;
        }

        public override string ToString()
        {
            return $"{_book} {_verse}";
        }
    }
}

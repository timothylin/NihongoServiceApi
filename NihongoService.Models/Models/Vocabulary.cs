namespace NihongoService.Models.Models
{
    public class Vocabulary : EntityBase
    {
        public int Id { get; set; }

        public string English { get; set; }

        public string Kana { get; set; }

        public string Kanji { get; set; }
    }
}

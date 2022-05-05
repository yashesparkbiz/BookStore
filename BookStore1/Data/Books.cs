namespace BookStore1.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int LanguageId { get; set; }

        public string CoverImageurl { get; set; }
        public string BookPdfurl { get; set; }
        public ICollection<BookGallery> bookGallery { get; set; }


    }
}

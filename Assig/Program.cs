namespace Assig
{
    public class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }


        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, Publication Date: {PublicationDate}, Price: {Price}";

        }
    }

    public class BookFunctions
    {

        public static string GetTitle(Book B)
        {
            return B.Title;
        }


        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }


        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }
    }

    public  delegate string BookFunctionsDelegate( Book B); 
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist , BookFunctionsDelegate fPtr)

        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>{new Book("1123", "C# Programming", new string[] { "Ahmed", "Ali" }, new DateTime(2021, 5, 15), 66), };

            LibraryEngine.ProcessBooks(books, delegate (Book B) { return B.ISBN; });

            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToShortDateString());
        }
    }
}

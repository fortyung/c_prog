namespace HelloWorld // there no need for this namespace
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string Atitle, string Aauthor, int Apages) // Creating a class with arguements
        {
            title = Atitle;
            author = Aauthor;
            pages = Apages;

        }

        public Book() // This will allowing us to create a book without arguements
        {

        }
    }

}
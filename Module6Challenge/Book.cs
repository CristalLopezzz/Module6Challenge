//Declares a public class named 'Book'
public class Book
{
    //Properties for books title author, isbn
    //'{get; set;}' syntax allows properties to be read and written to
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    //Constructor that initializes the corresponding properties of 'Book'
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Overrides the default 'ToString()' method
    // When it is called it returns a string represention of the book
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}
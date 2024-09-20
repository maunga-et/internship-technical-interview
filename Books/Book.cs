namespace Book;

class Book {
    public int id = 0;
    public string title;
    public string author;
    public string publicationYear;

    public Book(string title, string author, string publicationYear) {
        id = id + 1;
        title = title;
        author = author;
        publicationYear = publicationYear;
    }

    public void setTitle(string title) {
        title = title;
    }

    public void setAuthor(string author) {
        author = author;
    }

    public void setPublicationYear(string publicationYear) {
        publicationYear = publicationYear;
    }
}
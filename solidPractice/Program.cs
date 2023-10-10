using solidPractice;
DeleteBooks delete = new();
AddBooks addBooks = new();
GetFromLibrary libraryContent = new GetFromLibrary();
addBooks.AddBook("Tatiana", "Understand");
addBooks.AddBook("Waswa", "Condelences");
addBooks.AddBook("Robert Kiyosaki", "Rich dad poor dad");
delete.deleteBook("Tatiana", "Understand");
libraryContent.ShowBooks();
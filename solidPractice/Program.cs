using solidPractice;
ChangeLib changeLib = new ChangeLib();
GetFromLibrary libraryContent = new GetFromLibrary();
changeLib.AddBook("Tatiana", "Understand");
changeLib.AddBook("Waswa", "Condelences");
changeLib.AddBook("Robert Kiyosaki", "Rich dad poor dad");
libraryContent.ShowBooks();
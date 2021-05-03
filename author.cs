using System;
using System.Collections.Generic;

  class author: Person {

  //Properties
  public List<Book> BookList = new List<Book>();

  //Constructor

  public author(string fname, string lname, string email) : base(fname, lname) {
    Email = email;
    Console.WriteLine("Author");
  }

  //Methods

  public void DisplayInfo () {

    Console.WriteLine("My name is " + FirstName + " " + LastName + " and you can contact me at " + Email);
  }

  public void DisplayBooks() {

    foreach (Book n in BookList)
    { 
      n.Display();
      
    }
  }

  public void AddBook (Book b){
    BookList.Add(b);
  }

  public void RemoveBook(Book b){
    Book a = BookList.Find(o=>o.ISBN == b.ISBN);
    BookList.Remove(a);
  }

}
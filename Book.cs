using System;
using System.Collections.Generic;

class Book {

      //Auto-implemented properties
    
      public string Title { get; set; }
      public string ISBN { get; set; }
      public string AuthorInfo { get; set; } 
      public virtual DateTime PublishedOn { get; set; }
      public string PublishedBy { get; set; }
    

    //Constructors

  public Book() {    
    Title="Unknown";
    ISBN="Unknown";
    PublishedBy="Unknown";
    PublishedOn = DateTime.Today;
  }

  public Book (string title, string isbn, string authorinfo){  
    Title = title;
    ISBN = isbn;
    AuthorInfo = authorinfo;
    //PublishedBy="Unknown";
    //PublishedOn = DateTime.Today;
  }

  public Book (string title, string isbn, string authorinfo, DateTime published_on, string published_by) {
    Title = title;
    ISBN = isbn;
    AuthorInfo = authorinfo;
    PublishedOn=published_on;
    PublishedBy=published_by;
  }

  //Methods

  public void Display() {
    Console.WriteLine ("Book: " + Title + " was written by " + AuthorInfo + " was published on " + PublishedOn);
  }



}
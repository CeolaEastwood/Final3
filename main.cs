

using System;
using System.Collections.Generic;


class MainClass { 

  public static void Main (string[] args) {

  //Creating 6 Books

  Book b1 = new Book ("Something Wicked This Way Comes", "ISBN-0380729407", "Ray Bradbury" );
  Book b3 = new Book ("The Martian Chronicles", "ISBN-9781451678192", "Ray Bradbury" );
  Book b5 = new Book ("The October Country: Stories", "ISBN-034532448X", "Ray Bradbury" );
  Book b2 = new Book ("The Ghost Brigades", "ISBN-B001QS9TSE", "John Scalzi", Convert.ToDateTime("04/10/2010"), "TorBooks" );
  Book b4 = new Book ("Old Man's War", "ISBN-B000SEIK2S", "John Scalzi", Convert.ToDateTime("04/01/2007"), "TorBooks" );
  Book b6 = new Book ("The Last Colony", "ISBN-B000YJ85BI", "John Scalzi", Convert.ToDateTime("04/17/2012"), "TorBooks" );


  Rental r1 = new Rental ("The Ghost Brigades", Convert.ToDateTime("04/27/2021"), Convert.ToDateTime("04/05/2022") );
  Rental r2 = new Rental ("Old Man's War", Convert.ToDateTime("04/27/2021"), Convert.ToDateTime("04/05/2022") );
  Rental r3 = new Rental ("The Martian Chronicles", Convert.ToDateTime("04/27/2021"), Convert.ToDateTime("04/05/2022") );
  Rental r4 = new Rental ("Something Wicked This Way Comes", Convert.ToDateTime("04/27/2021"), Convert.ToDateTime("04/05/2022") );
  Rental r5 = new Rental ("The October Country: Stories", Convert.ToDateTime("04/27/2021"), Convert.ToDateTime("04/05/2022") );
  Rental r6 = new Rental ("The Last Colony", Convert.ToDateTime("04/27/2021"), Convert.ToDateTime("04/05/2022") );
  

  //Author 1
  author Ray = new author("Ray", "Bradbury", "R_B@gmail.com");
  Ray.DisplayInfo();
  Ray.AddBook(b1);
  Ray.AddBook(b3);
  Ray.AddBook(b5);
  Ray.DisplayBooks();
  Ray.RemoveBook(b1); 
  Ray.DisplayBooks();
  
  
  //Author 2
  author John = new author("John", "Scalzi", "j_s@gmail.com");
  John.DisplayInfo();
  John.AddBook(b2);
  John.AddBook(b4);
  John.AddBook(b6);
  John.DisplayBooks();
 
  Patron p1 = new Patron ("Kurt", "Miller", "QWE123");
  Patron p2 = new Patron ("Jane", "Kintz", "ASD456");
  Patron p3 = new Patron ("Chris", " Fritz", "ZXC789");
  Patron p4 = new Patron ("Samuel", "Jackman", "TYU963");
  Patron p5 = new Patron ("Shirley", "Slatts", "MLK654");

  Patron p1 = new Patron ("Kurt", "Miller", "QWE123");
  Patron p2 = new Patron ("Jane", "Kintz", "ASD456");
  Patron p3 = new Patron ("Chris", " Fritz", "ZXC789");
  Patron p4 = new Patron ("Samuel", "Jackman", "TYU963");
  Patron p5 = new Patron ("Shirley", "Slatts", "MLK654");

  LibraryCollection L1 = new LibraryCollection();

   L1.AddPatron(p1);
   L1.AddPatron(p2);
   L1.AddPatron(p3);
   L1.AddPatron(p4);
   L1.AddPatron(p5);
   L1.RemovePatron(p5);
   L1.DisplayPatronInfo();

   L1.AddToCollection(b1);
   L1.AddToCollection(b2);
   L1.AddToCollection(b3);
   L1.AddToCollection(b4);
   L1.AddToCollection(b5);
   L1.AddToCollection(b6);
   L1.RemoveFromCollection(b6);

   L1.DisplayCollection();

   p1.AddToRentalCart(b1, Convert.ToDateTime("04/07/2022"));
   p1.AddToRentalCart(b2, Convert.ToDateTime("04/07/2022"));
   p2.AddToRentalCart(b3, Convert.ToDateTime("04/07/2022"));
   p2.AddToRentalCart(b4, Convert.ToDateTime("04/07/2022"));
   p2.RemoveFromRentalCart(b4);

   L1.ProcessRental(p1);
   L1.ProcessRental(p2);
   L1.DisplayCollection();

   L1.ProcessReturns(p1, b1);
   L1.ProcessReturns(p2, b3);
   L1.DisplayCollection();

   

  }



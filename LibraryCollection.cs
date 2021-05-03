using System;
using System.Collections.Generic;
using System.Linq; 


class LibraryCollection {

//Properties
private List<Patron> PatronList = new List<Patron>();
private List<Book> BookList = new List<Book>(); 

//Methods

public void AddPatron(Patron p){
  PatronList.Add(p);
  Console.WriteLine("Added to Patron List: " + p.FirstName +" " + p.LastName);
}
public void RemovePatron (Patron p){
    Patron a = PatronList.Find(o=>o.LibraryId == p.LibraryId);
    PatronList.Remove(a);
  
    Console.WriteLine("Removed From Patron List: "+ p.FirstName +" " + p.LastName);
}
public void DisplayPatronInfo(){

  foreach (Patron p in PatronList)
  { 
    p.PatronDisplay();
  }
}
public void AddToCollection (Book b){
  BookList.Add(b);
  Console.WriteLine("Book added! " + b.Title);
}
public void RemoveFromCollection (Book b ){
  Book f = BookList.Find(o=>o.ISBN == b.ISBN);
  BookList.Remove(f);
  Console.WriteLine("Book Removed!: " + b.Title);
}
public void DisplayCollection (){

  Console.WriteLine("Books in the current Collection:");

  foreach (Book b in BookList)
  { 
  b.Display();
  }
}



public void ProcessRental (Patron p){

  foreach (Rental r in p.RentalList){

    BookList.Remove(r.RentalBook);
   
    Console.WriteLine("Checkout complete - Removed From Library Collections: "+ r.RentalBook.Title);
  }
}


public void ProcessReturns (Patron p, Book b ){
  Book f = BookList.Find(o=>o.ISBN == b.ISBN);
  //Rental r = p.RentalList.Find(o => o.Book == b);?? Duedate
  BookList.Add(b);
  p.RemoveFromRentalCart(b);
  //L1.AddToCollection(b);
  Console.WriteLine("Checkin complete - Added to Library Collections: "+ b.Title);

  }





}
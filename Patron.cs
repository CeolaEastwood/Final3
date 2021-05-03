

using System;
using System.Collections.Generic;

  class Patron: Person {

  //properties

public List<Rental> RentalList = new List<Rental>();

public string LibraryId { get; set; } 
public virtual DateTime EndDate { get; set; } 
public virtual DateTime StartDate { get; set; } 
bool IsAccountActive { get; set; } 
float FineAmountDue { get; set; } 

//constructor
public Patron(string fname, string lname, string libraryid) : base(fname, lname) {

LibraryId =libraryid;
FineAmountDue= 0;

//IsAccountActive = true;
//StartDate = DateTime.Today;

Console.WriteLine("Patron");
  }

// Method
public void PatronDisplay(){

  Console.WriteLine("Patron ID = "+ LibraryId);
  Console.WriteLine("Patron Name = "+ FirstName +" "+ LastName);

}

public void AddToRentalCart(Book RentalBook, DateTime DateDue){
  Rental z = new Rental(RentalBook, DateDue);
  RentalList.Add(z);

    Console.WriteLine("Added to rental cart: "+ RentalBook.Title + " for Patron "+ FirstName + " " + LastName);
  }

public void RemoveFromRentalCart(Book RentalBook){
  int index = 0;

  while (index < RentalList.Count) {

      if (RentalList[index].RentalBook.ISBN == RentalBook.ISBN) {
        RentalList.RemoveAt(index);

      }
      Console.WriteLine("Removed from rental cart: "+ RentalBook.Title + " for Patron "+ FirstName + " "+ LastName);
    }
  }


}

 
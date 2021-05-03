/* 
1. Create Rental class
•	Properties
a.	Book (Book object)
b.	DateRented (Date)
c.	DateDue (Date)
•	Constructor
a.	One constructor that takes 3 parameters
•	Methods
a.	None
*/


using System;
using System.Collections.Generic;

class Rental {

//Properties
public Book RentalBook;
public DateTime DateRented; //{ get; set; }
public DateTime DateDue;  //{ get; set; }

//Constructor

public Rental (Book rentalbook, DateTime datedue){  

    RentalBook = rentalbook;
    DateDue = datedue;
    //DateRented = DateTime.Today;
  }
}


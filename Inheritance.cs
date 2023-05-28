using Logicalprogram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    //public class man

    //{
    //    public string Name;
    //    public int Age;
    //}
    //public class Employee:man 
    //{
    //    public int empid;
    //    public int salary;

    //    public void Display()
    //    {
    //        Console.WriteLine("Nmae-" +Name);
    //        Console.WriteLine("Age-" + Age);
    //        Console.WriteLine("Id-" + empid);
    //        Console.WriteLine("salary-" + salary);
    //    }
    // class - a class is templet or blue print from which object are created
    // object - an object is an entily that has state and behivours
    // inheritance - when one object is aquire all the properties when and bheivour of parent oject is called inheritance
    //method - a method is group of statement that together perfrom tasks 
    //counstractor - it is used to intalized the data member of new object
    //interface - is used to achive multiple class one line we cant create an object
    //single inheritance - when one class inheritance another class that time can we say its single inheritance
    //multi level inheritance - one class is derived from another class then this type inheritance is called multi level inheritance
    // multiple inheritance - in multiple inheritance a single derived class inherits from multiple base classes
    //C# is doesnt support multiple inheritance
    //interface - interface of C# is blueprint of a class . it is like absstract class because all method which is decleare
    // inside the interface are abstarct method .it can not have aa method body and canot intalized
    // herichacal inheritance this is the type of ineheritance whch there multiple classes is derived from one base class 

    // 2)Encapsulstion - is process of binding the data members and member funcutions into single unit is called encompulstion
    // how to  achive or implement encapsulation 
    //1- Declering the instant variable as private 
    //2 - provide the public getter and setter method 

    //3) Polymorphism -
    // poly means many 
    //morphsim - form and behaivours
    //types 
    //1) method oveloding or compile time overloding -
    //creating one or more method or function having same name but different signature or the parameters in the same class method over loding
    //2)method overriding or run time polymorphism-
    //creating a method  of derived class with same signature as a method in the base class is called as method overriding 
    //Having two methods with same name and same signature one should be in base class other should be in base class

    //4) Abstarction =
    //- it means that only is requried information is visible to the user and the rest information is hidden 
    //it is used to display only nesserry and essential features of an object to outside to the world 
    //abstarction can achived with the either abstarctor classes or interface

    public class Grandparent
    {
        public void Home()
        {
            Console.WriteLine("Home");

        }
    }
    public class parent: Grandparent
    {
        public void Bike ()
        {
            Console.WriteLine("Bike");
        }
    }
    public class child : parent
    { 
    
    
    }

   
}



















    
    



    
    
   


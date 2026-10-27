// // // Car car = new Car(0);

// // //         int amount = int.Parse(Console.ReadLine());

// // //         car.Refuel(amount);
// // //         car.Drive();

// //   string name = Console.ReadLine();

// //         Dog dog = new Dog();

// //         dog.SetName(name);

// //         Console.WriteLine(dog.GetName());
// //         dog.Eat();

// using System;

// interface Readable
// {
//     void Read();
// }

// interface Borrowable
// {
//     void Borrow();
//     void ReturnBook();
// }

// abstract class AbstractBook : Readable
// {
//     public string Title;
//     public string Author;

//     public void SetTitle(string title)
//     {
//         Title = title;
//     }

//     public string GetTitle()
//     {
//         return Title;
//     }

//     public void SetAuthor(string author)
//     {
//         Author = author;
//     }

//     public string GetAuthor()
//     {
//         return Author;
//     }

//     public void Read()
//     {
//         Console.WriteLine("Reading");
//     }
// }

// class Book : AbstractBook, Borrowable
// {
//     public void Borrow()
//     {
//         Console.WriteLine("Book borrowed");
//     }

//     public void ReturnBook()
//     {
//         Console.WriteLine("Book returned");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Book book = new Book();

//         book.SetTitle("Harry Potter");
//         book.SetAuthor("J.K. Rowling");

//         Console.WriteLine(book.GetTitle());
//         Console.WriteLine(book.GetAuthor());

//         book.Read();
//         book.Borrow();
//         book.ReturnBook();
//     }
// }

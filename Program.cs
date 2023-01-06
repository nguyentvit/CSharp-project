using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections;
namespace Namespace
{
    public class Program
    {
        
        static void Main(string[] args)
        {
          BookList b1 = new BookList();
          b1.InputList();
          b1.ShowList();
          

        }
        interface IBook
        {
            string this[int index]
            {
                get;
                set;
            }
            string Title
            {
                get;
                set;

            }
            string Author
            {
                get;
                set;
            }
            string Publisher
            {
                get;
                set;
            }
            string ISBN
            {
                get;
                set;
            }
            int Year
            {
                get;
                set;
            }
            void Show();
        }
        class Book : IBook
        {
            #region 
            private string isbn;
            private string tittle;
            private string author;
            private string publisher;
            private int year;
            private ArrayList chapter = new ArrayList();
            #endregion

            public string this[int index]
            {
                get
                {
                    if(index >= 0 && index < chapter.Count)
                    {
                        return (string)chapter[index];
                    }
                    else throw new IndexOutOfRangeException();
                }
                set
                {
                    if(index >= 0 && index < chapter.Count)
                    {
                        chapter[index] = value;
                    }
                    else if (index == chapter.Count)
                    {
                        chapter.Add(value);
                    }
                    else{
                        throw new IndexOutOfRangeException();
                    }
                }
            }
            public string Title
            {
                get
                {
                    return tittle;
                }
                set
                {
                    tittle = value;
                }
            }
            public string Author
            {
                get
                {
                    return author;
                }
                set
                {
                    author = value;
                }
            }
            public string Publisher
            {
                get
                {
                    return publisher;
                }
                set
                {
                    publisher = value;
                }
            }
            public string ISBN
            {
                get
                {
                    return isbn;
                }
                set
                {
                    isbn = value;
                }
            }
            public int Year
            {
                get
                {
                    return year;
                }
                set
                {
                    year = value;
                }
            }
            public void Show()
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Title: " + tittle);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Publisher: " + publisher);
                Console.WriteLine("Year: " + year);
                Console.WriteLine("ISBN: " + isbn);
                Console.WriteLine("Chapter: " );
                for(int i=0;i < chapter.Count;i++)
                {
                    Console.WriteLine("\t{0}: {1}",i+1,chapter[i]);
                }
                Console.WriteLine("-----------------------");

            }
            public void Input()
            {
                Console.Write("Tittle: ");
                tittle = Console.ReadLine();
                Console.Write("Author: ");
                author = Console.ReadLine();
                Console.Write("Publisher: ");
                publisher = Console.ReadLine();
                Console.Write("ISBN: ");
                isbn = Console.ReadLine();
                Console.Write("Year: ");
                year =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input chapter (finished with empty string)");
                string str;
                do 
                {
                    str = Console.ReadLine();
                    if(str.Length > 0)
                    {
                        chapter.Add(str);
                    }
                }while(str.Length > 0);



            }
            }

        class BookList
        {
            private ArrayList list = new ArrayList();   
            public void AddBook()
            {
                Book b = new Book();
                b.Input();
                list.Add(b);

            }
            public void ShowList()
            {
                foreach(Book b in list)
                {
                    b.Show();
                }
            }
            public void InputList()
            {
                int n;
                Console.Write("Amount of books: ");
                n = int.Parse(Console.ReadLine());
                while(n>0)
                {
                    AddBook();
                    n--;
                }
            }
        }
        }

        
    }
    
        
    
    

    

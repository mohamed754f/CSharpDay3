using System.Diagnostics.SymbolStore;

namespace CSharpDay3
{
    internal class Program
    {
        class Book
        {
            private static int count = 0;

            #region Set&Get
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Createdon { get; set; }
            public bool IsDeleted { get; set; }
            public int Price { get; set; }


            #endregion

            #region Constractor
            public Book(int id, string name, string type, string createdon, int price, bool isdeleted)
            {
                Id = id;
                Name = name;
                Type = type;
                Createdon = createdon;
                Price = price;
                IsDeleted = isdeleted;
                count++;
            }
            public Book(int id, string name, string type, int price, bool isdeleted)
            {
                Id = id;
                Name = name;
                Type = type;
                Price = price;
                IsDeleted = isdeleted;
                count++;
            }
            public Book(int id, string name, int price , bool isdeleted)
            {
                Id = id;
                Name = name;
                Price = price;
                IsDeleted = isdeleted;
                count++;
            }
            public Book(int id, string name, bool isdeleted)
            {
                Id = id;
                Name = name;
                IsDeleted = isdeleted;
                count++;
            }
            #endregion

            public void GetDataBook()
            {
                Console.WriteLine($"ID = {Id}\nName = {Name}\nType = {Type}\nData Time = {Createdon}\nPrice = {Price}");
            }
            public void Deleted()
            {
                if (IsDeleted == true)
                    Console.WriteLine("The Book is Deleted");
                else
                    Console.WriteLine("The Book is Not Deleted");
            }

            public static void HowManyBookBorrow()
            {
                Console.WriteLine($"\t\tMany Book Borrow {count}");
            }
        }

        static void Main(string[] args)
        {
            Book book1 = new Book(1, "C#", "Web", "5/10/2000", 1000,true);
            Book book2 = new Book(1, "C#", "Web", 1000, false);
            Book book3 = new Book(1, "C#", 1000, true) ;
            Book book4 = new Book(1, "C#", false);

            Book.HowManyBookBorrow();

            book1.GetDataBook();
            book1.Deleted();
            Console.WriteLine("\n");
            book2.GetDataBook();
            book2.Deleted();
            Console.WriteLine("\n");
            book3.GetDataBook();
            book3.Deleted();
            Console.WriteLine("\n");
            book4.GetDataBook();
            book4.Deleted();
        }
    }
}

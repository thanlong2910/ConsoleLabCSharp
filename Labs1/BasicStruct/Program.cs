using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStruct
{
    struct Books
    {
        public string name;
        public string author;
        public int page;
        public int price;

        public void displayBook()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("author: {0}", author);
            Console.WriteLine("pages: {0}", page);
            Console.WriteLine("price: {0}", price);
        }
    };

    struct Journals
    {
        private string name;
        private int page;

        public void setJournalValue(string tempName, int tempPage)
        {
            name = tempName;
            page = tempPage;
        }

        public void displayJournal()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("pages: {0}", page);
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            // Books
            Books book1;
            book1.name = "Thep da toi the day";
            book1.author = "Author1";
            book1.page = 500;
            book1.price = 150000;

            book1.displayBook();

            // Journals
            Journals journal1 = new Journals();
            journal1.setJournalValue("Tap chi suc khoe", 35);
            journal1.displayJournal();

            Console.ReadLine();
        }
    }
}

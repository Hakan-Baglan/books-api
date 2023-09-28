using bookDemo.Models;

namespace bookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book() {Id=1, Title="Kargöz ve Hacivat", Price=75 },
                new Book() {Id=2, Title="Kel Oğlan", Price=145 },
                new Book() {Id=3, Title="7. Koğuştaki Mucize", Price=124 },
            };
        }
    }
}

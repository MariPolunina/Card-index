namespace Library
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;

    public class LibraryDataBase : DbContext
    {
        // Контекст настроен для использования строки подключения "LibraryDataBase" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Library.LibraryDataBase" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LibraryDataBase" 
        // в файле конфигурации приложения.
        public LibraryDataBase()
            : base("name=LibraryDataBase")
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Book> MyBook { get; set; }
        public virtual DbSet<Author> MyAuthor { get; set; }
    }
    public class Book
    {
        public int IDBook { get; set; }
        public string NameofBook { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }
    }
    public class Author
    {
        public int IDAuthor { get; set; }
        public string NameofAuthor { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
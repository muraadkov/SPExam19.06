namespace SPExam19._06
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EssenseContext : DbContext
    {
        // Контекст настроен для использования строки подключения "EssenseContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SPExam19._06.EssenseContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "EssenseContext" 
        // в файле конфигурации приложения.
        public EssenseContext()
            : base("name=EssenseContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
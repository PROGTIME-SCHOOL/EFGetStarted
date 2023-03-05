using EFGetStarted;
using Microsoft.Data.Sqlite;

class Program
{
    public static void Main()
    {
        //SqliteConnection connection = new SqliteConnection("Data Source=users.db");
        //connection.Open();

        MyContext db = new MyContext();

        Console.WriteLine(db.DbPath);

        User user = new User()
        {
            Name = "Test", Email = "Email", PhoneNumber = "000000"
        };

        db.Users.Add(user);
        db.SaveChanges();

        Console.ReadLine();   // pause
    }
}
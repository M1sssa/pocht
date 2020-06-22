using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите адресата");
            string adr = Console.ReadLine();

            Console.Write("Password");
            string parol = Console.ReadLine();

            Console.Write("Login");
            string login = Console.ReadLine();

            MailAddress from = new MailAddress("address@gmail.com", "NAME");
            MailAddress to = new MailAddress(adr);

            MailMessage objectMail = new MailMessage(from, to);
            objectMail.Subject = "Test";
            objectMail.Body = "<h2>Test</h2>";
            objectMail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(parol, login);
            smtp.EnableSsl = true;
            smtp.Send(objectMail);
            Console.Read();
        }

    }
}

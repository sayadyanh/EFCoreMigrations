using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ImageToText
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            using (var context = new DesignTimeDBContexFfactory().CreateDbContext(args))
            {
                context.Messages.Add(new Message
                {
                    Title = "4",
                    Body = "message body 4",
                    PhoneNumber = "+12345678900"
                });
                context.SaveChanges();

                foreach (var msg in context.Messages)
                {
                    Console.WriteLine($"Message: {msg.Id}\n{msg.Title}\n{msg.Body}\n{msg.PhoneNumber}\n");
                }
            }

            Console.ReadLine();
        }
    }
}

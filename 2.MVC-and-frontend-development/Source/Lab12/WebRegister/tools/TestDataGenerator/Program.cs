using System;
using System.IO;
using System.Text;

namespace TestDataGenerator
{
    class Program
    {
        static readonly Random random = new Random();

        static void Main(string[] args)
        {
            string namesFile = "names.txt";
            string outputFile = "Persons.sql";

            Console.WriteLine("Test Persons Data Generator");

            if (!File.Exists(namesFile))
            {
                Console.WriteLine($"File {namesFile} does not exists.");
                return;
            }

            var names = File.ReadLines(namesFile);

            using var writer = new StreamWriter(outputFile);
            foreach (string full_name in names)
            {
                (string first, string last) = GetName(full_name);
                var birth = GetBirthDate();
                var email = GetEmail(first, last);

                var statement = CreateInsertStatement(first, last, birth, email);
                writer.WriteLine(statement);
                writer.WriteLine("GO");

                Console.WriteLine(statement);
            }
        }

        static (string first, string last) GetName(string name)
        {
            string[] full_name = name.Split(' ');
            return (full_name[0], full_name[1]);
        }

        static DateTime GetBirthDate()
        {
            var startDate = new DateTime(1930, 1, 1);
            var endDate = new DateTime(2010, 1, 1);

            TimeSpan timeSpan = endDate - startDate;
            TimeSpan randSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            var date = startDate + randSpan;

            return date;
        }

        static string GetEmail(string first, string last)
        {
            var email = $"{first.ToLower()}.{last.ToLower()}@acme.com";
            return email;
        }

        static string CreateInsertStatement(string first, string last, DateTime birth, string email)
        {
            var sb = new StringBuilder();

            // Add some NULL values into the BirthDate and Email columns
            string birthDate = birth.Day % 3 != 0 ? $"'{birth:d}'" : "NULL";
            string emailAddr = email.Length % 5 != 0 ? $"'{email}'" : "NULL";

            sb.Append("INSERT INTO [dbo].[Persons] ([FirstName], [LastName], [BirthDate], [Email]) ");
            sb.Append($"VALUES ('{first}', '{last}', {birthDate}, {emailAddr});");

            return sb.ToString();
        }
    }
}

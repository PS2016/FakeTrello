using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Mock.Mock
{
   public class MockString
    {
        private static readonly List<string> Names = new List<string> { "User1", "User2", "User3", "User4" };
        private static readonly List<string> Comment = new List<string> { "Comment1", "Comment2", "Comment3", "Comment4" };
        private static readonly List<string> Task = new List<string> { "Task1", "Task2", "Task3", "Task4" };
        private static readonly List<string> Emails = new List<string> { "ps1@gmail.com", "ps2@gmail.com", "ps3@gmail.com", "ps4@gmail.com" };


        public static string GetName() => Names.OrderBy(x => Guid.NewGuid()).First();
        public static string GetComment() => Comment.OrderBy(x => Guid.NewGuid()).First();
        public static string GetTask() => Task.OrderBy(x => Guid.NewGuid()).First();
        public static string GetEmail() => Emails.OrderBy(x => Guid.NewGuid()).First();
        public static string Password() => "123456";
    }
}

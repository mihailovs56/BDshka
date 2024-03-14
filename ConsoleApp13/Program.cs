using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posts posts = new Posts();
            Likes likes = new Likes();
            Comments comments = new Comments();
            posts.Comments = comments;
            posts.Likes = likes;
            Sounds sounds = new Sounds();
            Console.WriteLine("Вывести данные о юзере:");
            User user = new User
            {
                Login = "mix333",
                Password = "123456",
                Numberphone = "+79123456789",
                Email = "mihailov2005mix333@gmail.com"
            };
            Console.WriteLine(user);
            Console.WriteLine("Вывести данные профиля этого юзера:");
            Profile profile = new Profile
            {
                Name = "Сергей",
                LastName = "Михайлов",
                ID = "@mihailovs56"
            };
            Console.WriteLine(profile);
            posts.Profile = profile;
            profile.User = user;
        }
        
        public class DataBase
        {
            public void SaveUser(User user)
            {
                // Код для сохранения данных пользователя в базе данных
            }

            public void SaveProfile(Profile profile)
            {
                // Код для сохранения данных профиля в базе данных
            }

            public void SaveFriend(Friends friend)
            {
                // Код для сохранения данных друга в базе данных
            }

            public void SaveLike(Likes like)
            {
                // Код для сохранения данных лайка в базе данных
            }

            public void SaveComment(Comments comment)
            {
                // Код для сохранения данных комментария в базе данных
            }

            public void SavePost(Posts post)
            {
                // Код для сохранения данных поста в базе данных
            }

            public void SaveSound(Sounds sound)
            {
                // Код для сохранения данных звука в базе данных
            }
        }
        public class User
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Numberphone { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                return $"Login: {Login}, Password: {Password}, Numberphone: {Numberphone}, Email: {Email}";
            }
        }
        public class Profile
        {
            public User User { get; set; }
            public string Name { get; set; }

            public string LastName { get; set; }
            public string ID { get; set; }
            public override string ToString()
            {
                return $"Name: {Name}, LastName: {LastName}, ID: {ID}";
            }
        }
        public class Friends
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string ID { get; set; }
            public string LastTime {  get; set; }
        }
        public class Likes
        {
            public string Whose { get; set; }
        }
        public class Comments
        {
            public string Whose { get; set; }
            public string Content { get; set; }

        }
        public class Posts
        {
            public Profile Profile { get; set; }
            public Likes Likes { get; set;}
            public Comments Comments { get; set;}
            public string Whose { get; set; }
            public string Content { get; set; }
            public string Time { get; set; }
        }
        public class Sounds
        {
            public string List { get; set; }
        }
    }
}

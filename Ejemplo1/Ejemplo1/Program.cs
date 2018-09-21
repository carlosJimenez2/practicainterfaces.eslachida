using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        public interface INotifications
        {
            void showNotifications();
            string getDate();
        }

        public class NotificationEspañol : INotifications
        {
            private string sender;
            private string message;
            private string date;

            public NotificationEspañol(string mySender, string myMessage, string myDate)
            {
                this.sender = mySender;
                this.message = myMessage;
                this.date = myDate;
            }

            public void showNotifications()
            {
                Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
            }

            public string getDate()
            {
                return date;
            }
        }

        public class Notification : INotifications
        {
            private string sender;
            private string message;
            private string date;

            public Notification()
            {
                sender = "Admin";
                message = "Yo, what's up?";
                date = "";
            }

            public Notification(string mySender, string myMessage, string myDate)
            {
                this.sender = mySender;
                this.message = myMessage;
                this.date = myDate;
            }

            public void showNotifications()
            {
                Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
            }

            public string getDate()
            {
                return date;
            }
        }

        static void Main(string[] args)
        {
            Notification n1 = new Notification("Denis", "Tsup bro?", "12.06.2018");
            Notification n2 = new Notification("Frank", "All good", "12.06.2018");
            NotificationEspañol n3 = new NotificationEspañol("Milton", "Hola hermano", "19092018");
            NotificationEspañol n4 = new NotificationEspañol("Charly", "Hola Hola", "19092018");

            n1.showNotifications();
            n2.showNotifications();
            n3.showNotifications();
            n4.showNotifications();

            Console.ReadLine();
        }

    }
}

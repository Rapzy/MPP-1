using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp
{
    public class Student
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public Student(string fullName, string group, bool sessionStart, bool newMessage, bool newShedule)
        {
            FullName = fullName;
            Group = group;
            if (sessionStart)
                MainForm.deanOffice.OnSessionStart += GetSessionStart;
            if (newMessage)
                MainForm.deanOffice.OnNewMessage += GetNewMessage;
            if (newShedule)
                MainForm.deanOffice.OnNewShedule += GetSessionStart;
        }
        public string GetSessionStart(string message)
        {
            return $"Student {FullName} [{Group}] got message: {message}\n";
        }
        public string GetNewMessage(string message)
        {
            return $"Student {FullName} [{Group}] got message: {message}\n";
        }
        public string GetNewShedule(string message)
        {
            return $"Student {FullName} [{Group}] got message: {message}\n";
        }
    }
}

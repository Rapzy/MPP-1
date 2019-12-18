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
        public void GetSessionStart(string message)
        {
            MainForm.cachedText += $"Student {FullName} [{Group}] got message: {message}\n";
        }
        public void GetNewMessage(string message)
        {
            MainForm.cachedText += $"Student {FullName} [{Group}] got message: {message}\n";
        }
        public void GetNewShedule(string message)
        {
            MainForm.cachedText += $"Student {FullName} [{Group}] got message: {message}\n";
        }
    }
}

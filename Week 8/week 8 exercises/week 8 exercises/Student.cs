using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_exercises
{
    class Student
    {
        //Define a class Student which contains the following information about a student: 
        //    full name, course, subject, university, email, and phone number.

        string fullName;
        string course;
        string subject;
        string university;
        string email;
        string phoneNumber;

        public string FullName { get { return this.fullName; } set { this.fullName = value; } }
        public string Course { get { return this.course; } set { this.course = value; } }
        public string Subject { get { return this.subject; } set { this.subject = value; } }
        public string University { get { return this.university; } set { this.university = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }

        //Declare 5 constructors for the class Student which have different parameters.
        public Student(string fullName)
        {
            this.fullName = fullName;
        }

        public Student(string fullName, string course)
        {
            this.course = course;
            this.fullName = fullName;
        }

        public Student(string subject, string course, string fullName)
        {
            this.subject = subject;
            this.course = course;
            this.fullName = fullName;
        }

        public Student (string fullName, string course, string subject, string university)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
        }

        public Student ()
        {
            this.fullName = "Dean Winchester";
            this.course = "Demonology";
            this.subject = "Exorcisms";
            this.university = "Hunter U.";
            this.email = "dean@winchester.com";
            this.phoneNumber = "8675309";
        }

        public void GetInfo ()
        {
            Student student = new Student();

            Console.WriteLine("The student's name is " + student.fullName + " and he/she is currently enrolled in the course " + 
                student.course + " at " + student.university + ". \nThe current subject of the course is " + student.subject + 
                ". \nContact the student at their email " + student.email + " or their phone " + student.phoneNumber + ".");
        }
    }
}

using System;
namespace StudentLibrary
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  DateTime DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"Surname: { LastName }, Name: { FirstName }, DateOfBirth: { DateOfBirth.ToLongDateString() }";
        }
    }
}
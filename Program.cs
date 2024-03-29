﻿using System;

namespace Phase1Section5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            Teacher teacher = new Teacher();
            teacher.Name = "Mr.Teacher";
            teacher.Address = "some address";
            teacher.DateOfJoining = DateTime.Today;

            Student student = new Student();
            student.Name = "Student name";
            student.Address = "some address";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Mr.Staff";
            staff.Address = "some address";
            staff.DateOfJoining = DateTime.Today;


            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
            Console.ReadKey();
        }
    }
}

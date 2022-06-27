// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace GradeSheet {

class Program {


static void Main(string[] args) {

    var book = new Book("Brandon's Book");
    book.AddGrade(89.1);
    book.AddGrade(90.5);
    book.AddGrade(88.8);
 var stats = book.GetStatistics();
 
Console.WriteLine($"The average grade of the course is {stats.Average:N1}");
Console.WriteLine($"The highest grade of the course is {stats.High}");
Console.WriteLine($"The lowest grade of the course is {stats.Low}");



}
}
}

using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._company = "Walmart";
       job1._jobtitle = "Project manager";
       job1._startyear = 2015;
       job1._endyear = 2019;

       Job job2 = new Job();
       job2._company = "Falabella";
       job2._jobtitle = "Human resource personnel";
       job2._startyear = 2018;
       job2._endyear = 2022;

       Resume myResume = new Resume();
       myResume._name = "Daniel Contreras";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.Display();

    }
}
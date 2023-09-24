using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Juicy";
        job1._jobTitle = "Senior Juicer";
        job1._startYear = 2020;
        job1._endYear = 2021;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Fried Chicken";
        job2._jobTitle = "Lead Chicken maker";
        job2._startYear = 2021;
        job2._endYear = 2022;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "John Jacob Jingle-Heimer-Schmidt";

        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.Display();
    }


}
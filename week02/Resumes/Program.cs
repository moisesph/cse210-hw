using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2001;
        job1._endYear = 2033;

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2005;
        job2._endYear = 2009;

        Resume myResume = new Resume();
        myResume._name = "Moises Pleytez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayJobs();
    }
}
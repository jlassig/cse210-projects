using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2022;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "USPS";
        job2._jobTitle = "Delivery Consultant";
        job2._startYear = 1980;
        job2._endYear = 2010;
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Bob Smith";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);
        myResume.DisplayResume();

    }
}
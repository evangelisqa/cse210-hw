using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company =  "Bluecreek Consultant Inc";
        job1._startYear = "2024";
        job1._startEnd = "2025";

        Job job2 = new job1();
        job2._jobTitle = "Website Developer";
        job2._company = "Sixteen Nine Enterprise Inc";
        job2._startYear = "2024";
        job2._startEnd = "2025";
        
        Resume myResume = new Resume();
        myResume._name = "Evangelis Albesa";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
       
    }
}
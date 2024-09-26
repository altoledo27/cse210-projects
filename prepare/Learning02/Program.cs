using System;


class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Senior Director of Developer Advocacy";
        job1._trackCompany = "GitHub";
        job1._startYear = 2024;
        job1._endYear = 2024;

        job job2 = new job();
        job2._jobTitle = "Podcast Host and Contributing Writer";
        job2._trackCompany = "Stack Overflow";
        job2._startYear = 2019;
        job2._endYear = 2024;

        job job3 = new job ();
        job3._jobTitle = "Co-Founder and Chief Product Officer";
        job3._trackCompany = "Cosyndi, Inc.";
        job3._startYear = 2016;
        job3._endYear = 2019;

        job job4 = new job ();
        job4._jobTitle = "Chief Technology Officer";
        job4._trackCompany = "Contenda";
        job4._startYear = 2016;
        job4._endYear = 2018;

        job job5 = new job ();
        job5._jobTitle = "Software Engineer & Developer Evangelist";
        job5._trackCompany = "Clarifai";
        job5._startYear = 2014;
        job5._endYear = 2015;

        resume myResume = new resume();
        myResume._name = "Cassidy Williams";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);
        myResume._jobs.Add(job5);

        myResume.Display();
    }
}
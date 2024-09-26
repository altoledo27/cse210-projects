using System;
public class job
    {
        public string _trackCompany;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
        public void Display(){
            Console.WriteLine($"{_jobTitle} ({_trackCompany}) {_startYear} - {_endYear}");
        }

    }
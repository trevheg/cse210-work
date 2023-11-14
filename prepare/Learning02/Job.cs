using System;

// A class that contains information about a job
public class Job
{   
    // Member variables including company, job title, start year, 
    // and end year
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}
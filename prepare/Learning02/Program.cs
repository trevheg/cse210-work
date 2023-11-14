using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Create a new job instance named job1
        Job job1 = new Job();
        // Set the member variables using the dot notation
        job1._company = "Bingbong.net";
        job1._jobTitle = "Head Bingbonger";
        job1._startYear = 1997;
        job1._endYear = 2001;
        // Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
        // Console.WriteLine(job1._company);
        // Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and replace them with calls to your new method.
        // job1.DisplayJobInformation();
        // Create a second job, set its variables, display this company on the screen as well.
        Job job2 = new Job();
        job2._company = "Fiddle Faddle Tech";
        job2._jobTitle = "Fiddle Engineer";
        job2._startYear = 2001;
        job2._endYear = 2005;
        // Console.WriteLine(job2._company);
        // Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and replace them with calls to your new method.
        // job2.DisplayJobInformation();
        // Return to your Program.cs. Add the end of the Main function, create a new instance of the Resume class.
        Resume resume1 = new Resume();
        resume1._applicantName = "Bob Weattababieetsaboy";
        // Add the two jobs you created earlier, to the list of jobs in the resume object.
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);
        // Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle .
        // Console.WriteLine(resume1.jobs[0]._jobTitle);
        // Return to your main function, remove any code that is displaying information, and instead, add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line.
        resume1.DisplayResume();
        
    }
}
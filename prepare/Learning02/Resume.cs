using System;

public class Resume
{
    // Create the member variable for the person's name.
    public string _applicantName;
    // Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job> , and it is probably easiest to initialize this to a new list right when you declare it..)
    public List<Job> jobs = new List<Job>(); 
    // Return to your Resume class and add a method to display its details.
    // This method should not have any parameters and should not return anything.
    // In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them.
    // Hint: remember that you can call each job's Display method that you created earlier.
    public void DisplayResume()
    {
        Console.WriteLine("Name: " + _applicantName);
        Console.WriteLine("Jobs: ");
        foreach (Job j in jobs)
        {
            j.DisplayJobInformation();
        }
    }
}
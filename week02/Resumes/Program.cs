using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job_class_instance1 = new Job();
        job_class_instance1._company = "Microsoft";
        job_class_instance1._jobTitle = "Software Engineer";
        job_class_instance1._startYear = "2019";
        job_class_instance1._endYear = "2022";
        //job_class_instance1.Display();


        Job job_class_instance2 = new Job();
        job_class_instance2._company = "Apple";
        job_class_instance2._jobTitle = "Manager";
        job_class_instance2._startYear = "2022";
        job_class_instance2._endYear = "2023";
        //job_class_instance2.Display();

        Resume resume_class_instance1 = new Resume();
        resume_class_instance1._name= "Leonardo Barbosa";
        resume_class_instance1._jobs.Add(job_class_instance1);
        resume_class_instance1._jobs.Add(job_class_instance2);
        resume_class_instance1.Display();

        Console.WriteLine();



    }
}

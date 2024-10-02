using System;

using static Job;
using static Resume;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        List<Job> jbs = new() {job1, job2};

        Resume b = new Resume("joe", jbs);

        b.Display();

    }
}
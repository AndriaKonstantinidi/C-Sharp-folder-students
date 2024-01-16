using ConsoleApp24;

string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Students";

DirectoryInfo dir = new DirectoryInfo(dirPath);

dir.Create();


List<Students> studentsgraded = new List<Students>()
{
            new Students(){ Name = "John Doe", Grade = 94},
            new Students(){ Name = "Jane Doe", Grade = 81},
            new Students(){ Name = "Sock Toe", Grade = 100},
            new Students(){ Name = "Brohn Roe", Grade = 76}
};


List<failStudents> failedstudents = new List<failStudents>()
{
            new failStudents(){ Name = "Ron Moe", failGrade = 31},
            new failStudents(){ Name = "Zane Broe", failGrade = 43},
            new failStudents(){ Name = "Lock Yoe", failGrade = 22},
            new failStudents(){ Name = "Wake Soe", failGrade = 15}
};



foreach(var student in studentsgraded)
{
    Console.WriteLine(student.Name + " " + student.Grade);

    DirectoryInfo studDir = dir.CreateSubdirectory("Passed");

    DirectoryInfo studDirPass = studDir.CreateSubdirectory("Passed Student");

    DirectoryInfo studDir1 = studDirPass.CreateSubdirectory($"{student.Name}");

    FileManager.WriteFile(studDir1.FullName + $@"\{student.Name}.txt", $"{student.Name + " " + student.Grade}");
}

Console.WriteLine("-----------------");

foreach (var failure in failedstudents)
{
    Console.WriteLine(failure.Name + " " + failure.failGrade);

    DirectoryInfo failDir = dir.CreateSubdirectory("Failed");

    DirectoryInfo studNameFail = failDir.CreateSubdirectory("Failed Student");

    DirectoryInfo studFail1 = studNameFail.CreateSubdirectory($"{failure.Name}");

    FileManager.WriteFile(studFail1.FullName + $@"\{failure.Name}.txt", $"{failure.Name + " " + failure.failGrade}");
}

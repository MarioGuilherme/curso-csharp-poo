int numberOfStudents;

HashSet<int> studentsCourseA = new(),
             studentsCourseB = new(),
             studentsCourseC = new(),
             allStudents = studentsCourseA;

Console.Write("How many students for course A? ");
numberOfStudents = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfStudents; i++)
    studentsCourseA.Add(int.Parse(Console.ReadLine()));

Console.Write("How many students for course B? ");
numberOfStudents = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfStudents; i++)
    studentsCourseB.Add(int.Parse(Console.ReadLine()));

Console.Write("How many students for course C? ");
numberOfStudents = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfStudents; i++)
    studentsCourseC.Add(int.Parse(Console.ReadLine()));

allStudents.UnionWith(studentsCourseB);
allStudents.UnionWith(studentsCourseC);

Console.WriteLine($"Total students: {allStudents.Count}");
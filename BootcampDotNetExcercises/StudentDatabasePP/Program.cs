using StudentDatabasePP;

Student student = new Student("Brad");
student.Address = new Address("123 Here", "This City", "State", "45445");
student.Favorites = new Favorites("brownies", "green", "Van Helsing", "LOTR");

student.Favorites.Color = "orange";
student.Address.State = "Ohio";

Console.WriteLine($"{student.Name} live is {student.Address.GetHomeTown()}");
Console.WriteLine(student.Favorites.GetFavorite("food"));
Console.WriteLine(student.Favorites.GetFavorite("book"));
Console.WriteLine(student.Favorites.GetFavorite("color"));
Console.WriteLine(student.Favorites.GetFavorite("movie"));

List<Student> students = new List<Student>();
students.Add(student);

int studentIndex = 0;

Console.WriteLine("what category");
string input =Console.ReadLine();

Console.WriteLine(students[studentIndex].Favorites.GetFavorite(input));

Console.ReadKey();


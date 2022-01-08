using ExamplePOO.Helper;
using ExamplePOO.interfaces;
using ExamplePOO.Models;


FileHelper fh = new FileHelper();

string path = "C:\\Users\\marco\\Documents\\www\\dotnet-study\\dio-desafio-github\\ExamplePOO\\FolderTest";
string pathFile = Path.Combine(path, "Folder3", "file-test-steam");
string pathFile2 = Path.Combine(path, "Folder3", "file-test");
var listString = new List<string> { "Line 1", "Line2", "Line 3" };
var listStringAppend = new List<string> { "Line 4", "Line 5", "Line 6" };


// fh.ListDirectories("C:\\Users\\marco\\Documents\\www\\dotnet-study\\dio-desafio-github\\ExamplePOO\\FolderTest");

// fh.ListFilesInFolder(path);
// 
// fh.CreateDirectory(Path.Combine(path, "Folder3", "subFolder3"));

// fh.deleteDirectory(Path.Combine(path, "Folder1"), true);

// fh.CreateTxtFile(pathFile, "Writing file txt");

// fh.CreateTxtFileStream(pathFile, listString);

// fh.AddTextInFileStream(pathFile, listStringAppend);

// fh.ReadFileSteam(pathFile);

// fh.MoveFile(pathFile, pathFile2, true);

// fh.CopyFile(pathFile, pathFile2, false);

fh.DeleteFile(pathFile2);

// iCalculator calc = new Calculator();

// System.Console.WriteLine(calc.Subtract(10, 4));


// CheckingAccount c = new CheckingAccount();
// c.Credit(100);

// c.ShowSale();



// Calculator c = new Calculator();
// System.Console.WriteLine("Resultado da soma: " + c.Sum(4, 5));
// System.Console.WriteLine("Resultado da soma: " + c.Sum(4, 5, 6));

// Student p1 = new Student();
// p1.Name = "Marcos";
// p1.Age = 12;
// p1.Note = 10;
// p1.Show();

// Professor p2 = new Professor();
// p2.Name = "Marcos";
// p2.Age = 12;
// p2.Salary = 1500;
// p2.Show();




// Rectangle r = new Rectangle();
// r.SetMeasures(10, 15);
// System.Console.WriteLine(r.CalcArea());

// Rectangle r2 = new Rectangle();
// r2.SetMeasures(10, 0);
// System.Console.WriteLine(r2.CalcArea());


// Person p1 = new Person();
// p1.Name = "Marcos";
// p1.Age = 12;

// p1.Show();
using ComicBookVendor;
using System.IO;


const string bookFilePath = @"C:\Stuff\ComicBook.txt";

// Create the data

/*
ComicBookSeries series = new ComicBookSeries()
{
    SeriesName = "See Sharp to Be Sharp",
    IssueCountForSeries = 5
};

ComicBook variablesBook = new ComicBook
{
    UpcNumber = "1234",
    Title = "Variables Make Things Work",
    PurchasedDate = DateTime.Parse("01/01/2022"),
    PurchasePrice = 40
};
series.InStockIssues.Add(variablesBook.UpcNumber, variablesBook);

ComicBook conditionsBook = new ComicBook
{
    UpcNumber = "12345",
    Title = "If You Can't Decide, Switch It",
    PurchasedDate = DateTime.Parse("02/01/2022"),
    PurchasePrice = 50
};
series.InStockIssues.Add(conditionsBook.UpcNumber, conditionsBook);

ComicBook loopsBook = new ComicBook
{
    UpcNumber = "123456",
    Title = "Loop Until You Get It Right",
    PurchasedDate = DateTime.Parse("03/01/2022"),
    PurchasePrice = 60
};
series.InStockIssues.Add(loopsBook.UpcNumber, loopsBook);



StreamWriter bookWriter = new StreamWriter(bookFilePath, false);

foreach (ComicBook comic in series.InStockIssues.Values)
{
    bookWriter.WriteLine($"{comic.UpcNumber}|{comic.Title}|{comic.PurchasedDate}|{comic.PurchasePrice}");
}
bookWriter.Flush();
bookWriter.Close();
*/

List<ComicBook> books = new List<ComicBook>();

StreamReader reader = new StreamReader(bookFilePath);
while (true)
{
    string line = reader.ReadLine();
    // Leave the loop if the end of file is reached
    if (line == null)
    {
        break;
    }

    string[] atrributes = line.Split('|');
    ComicBook comicBook = new ComicBook
    {
        UpcNumber = atrributes[0],
        Title = atrributes[1],
        PurchasedDate = DateTime.Parse(atrributes[2]),
        PurchasePrice = double.Parse(atrributes[3])
    };
    books.Add(comicBook);

    Console.WriteLine($"{comicBook.Title} was purchased on {comicBook.PurchasedDate: MM/dd/yyyy} for {comicBook.PurchasePrice:c}");
}

Console.ReadKey();
















/*


// System IO objects
string directory = @"c:\stuff\";
string fileName = @"c:\stuff\file.txt";

DirectoryInfo directoryInfo = new DirectoryInfo(directory);
string[] directories = Directory.GetDirectories(@"c:\");

if (directories.Contains(directory) == false)
{
    Directory.CreateDirectory(directory);
}

//File.Create(fileName);
//FileInfo file = new FileInfo(fileName);
string title = "\"Green Eggs and Ham\"";
// Console.WriteLine(title);

// Console.WriteLine($"Stuff{Environment.NewLine}");

StreamWriter writer = new StreamWriter(fileName,true);
writer.Write("Word ");
writer.WriteLine("word 2");
writer.WriteLine("Line");
writer.Flush();
writer.Close();


StreamReader reader = new StreamReader(fileName);
string fullText = reader.ReadToEnd();

if (fullText.ToLower().Contains("scott") )
{
   // Console.WriteLine("This is about me");
}

while(true)
{
    string line = reader.ReadLine();
    if(line == null)
    {
        break;
    }
  //  Console.WriteLine(line);
}
reader.Close();

writer = new StreamWriter(fileName, true);
writer.Write("Word ");


*/





using System.Text;

string title = "Refactoring";

        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;

            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;

            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        // 1st answer


        int pages = 464;

        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

        Console.WriteLine(sizeLabel);


// 2nd answer

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int y = 0; y < books.Length; y++)
{
    Console.WriteLine("ENTER BOOK NUMBER(0,1,2)");
int Num = int.Parse(Console.ReadLine());
    Console.WriteLine( books[Num]);
}

// 3rd answer




int i = 0;

while (i < books.Length)
{
    Console.WriteLine(books[i]);
    i++;
}


// 4th answer

int q = 0;

do
{
    Console.WriteLine(books[q]);
    q++;
}
while (q < 3);


// 5th answer


foreach (string book in books)
{
    Console.WriteLine(book);
}

// 6th answer

string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

foreach (string book in books2)
{
    Console.WriteLine(book);

    if (book == "Refactoring")
    {
        break;
    }
}

// 7th answer



foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }

    Console.WriteLine(book);
}

// 8th answer




static void PrintFirstBook(string[] books)
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine(books[0]);
}

PrintFirstBook(books);

// 9th answer

string title2 = "clean code";

string upperTitle = title2.ToUpper();

Console.WriteLine(title2);
Console.WriteLine(upperTitle);

// 10th answer


string title1 = "Clean Code";
string title3 = "Clean Code";

Console.WriteLine(ReferenceEquals(title1, title3));


// 11th answer

     System.Text.StringBuilder sb = new System.Text.StringBuilder();
     sb.Append("Book List");
     sb.Append(" - Updated");

    Console.WriteLine(sb.ToString());

// 12th answer



        StringBuilder sb1 = new StringBuilder("Book List - Updated");

        sb.Replace("Book List", "Library");

        Console.WriteLine(sb.ToString());

// 13th answer



        string title4 = "Library";
        string status = "Updated";

        string result = $"{title} - {status}";

        Console.WriteLine(result);

// 14th answer





string title5 = "Library";
string status1 = "Updated";

string result1 = string.Format("{0} - {1}", title, status);

Console.WriteLine(result);


// 15th answer




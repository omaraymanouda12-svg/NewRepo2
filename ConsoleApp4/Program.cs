


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

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine("ENTER BOOK NUMBER(0,1,2)");
int Num = int.Parse(Console.ReadLine());
    Console.WriteLine( books[Num]);
}

// 3rd answer

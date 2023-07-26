using System.Reflection;

var todos = new List<string>();

bool shallExit = false;
while (!shallExit) {
    Console.WriteLine();
    Console.WriteLine("Hello");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a new TODO");
Console.WriteLine("[R]emovee a TODOs");
Console.WriteLine("[E]xit");



//setando inputs


//printando texto base
void PrintSelecectedOption(string SelectedOption)
{
    Console.WriteLine("Selected option:" + SelectedOption);
}

var userChoice = Console.ReadLine();

switch (userChoice)
    {
   case "E":
   case "e":
        shallExit=true;
        break;
        case "S":
    case "s":
        PrintSelecectedOption("See all TODOS");
        break;
    case "A":
    case "a":
            AddTodo();
        break;
    case "R":
    case "r":
            RemoveTodo();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
    }
}

//adicionando uma tarefa
void AddTodo()
{
    bool isValidDescription = false;
    while(!isValidDescription) { 
    Console.WriteLine("Enter a TODO description: ");
    var description = Console.ReadLine();

    if(description == "")
    {
        Console.WriteLine("The description cannot be empty");
    } else if (todos.Contains(description))
    {
        Console.WriteLine("The TODO already exists!");
    } else
    {
        isValidDescription = true;
        todos.Add(description);
    }
    }
}

// mostrando todas as tarefas

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        noTodosMessage();
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            string? todo = todos[i];
            Console.WriteLine($"{i++}.{todos[i]}");
        }
    }
}


//deletando uma tarefa

    void RemoveTodo()
    {
        if(todos.Count == 0)
        {
        noTodosMessage();
            return;
        }
        bool isIndexValid = false;
        while(!isIndexValid) { 
        Console.WriteLine("Select the index of the TODO you want to purge");
        SeeAllTodos();
            var userInput = Console.ReadLine();
            if(userInput == "")
            {
                Console.WriteLine("Selected index cannot be empty ");
                continue;
            }
            if(int.TryParse(userInput, out int index)&&
                index >=1 &&
                index <= todos.Count)
            {
                var indexOfTodo = index - 1;
                var todoToBeRemoved = todos[indexOfTodo];
                todos.RemoveAt(indexOfTodo);
                isIndexValid = true;
                Console.WriteLine("TODO purged: " + todoToBeRemoved);
            }
            else { Console.WriteLine("the given index isn't valid.");
            }
        }
    }

Console.ReadKey();

static void noTodosMessage()
{
    Console.WriteLine("No TODOS have been added yet");
}


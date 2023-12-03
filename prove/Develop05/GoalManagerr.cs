public class GoalManager
{
    private readonly List<Goal> _goals;
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {    
        int userChoice;

        do 
        {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1.- Create New Goal");
        Console.WriteLine("2.- List Goals");
        Console.WriteLine("3.- Save Goals");
        Console.WriteLine("4.- Load Goals");
        Console.WriteLine("5.- Record Event");
        Console.WriteLine("6.- Quit");
        Console.Write("Select a choice from the menu:  ");
    
        string menuOption = Console.ReadLine();
        userChoice = int.Parse(menuOption);          
                
            if (userChoice == 1)
            {
                CreateGoal();  
            }
            else if (userChoice == 2)
            {
                ListGoalDetails();
            }
            else if (userChoice == 3)
            {
                SaveGoals();   
            }
            else if (userChoice == 4)
            {
                LoadGoals();
            }
            else if (userChoice == 5)
            {
                RecordEvent();
            }


        } while (userChoice != 6);

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_score} points");
    }

    public void ListGoalNames() 
    {
        foreach (Goal goal in _goals)
        {
            int goalIndex = _goals.IndexOf(goal) + 1;
            string line = goalIndex.ToString() + ". " + goal.GetName();
            Console.WriteLine(line);
        }
    }

    public void ListGoalDetails()
    {   
        if (_goals == null ||_goals.Count == 0)
        {   
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no goals");
            Console.ResetColor();
            return;
        }
        foreach (Goal item in _goals)
        {
            Console.WriteLine(item.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1.- Simple Goal");
        Console.WriteLine("2.- Eternal Goal");
        Console.WriteLine("3.- Checklist Goal");
        Console.Write("Which type of goal would you like to create?  ");

        string choseGoal = Console.ReadLine();
        int answer = int.Parse(choseGoal);

        Console.Write("What is the name of your goal?  ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?  ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?  ");
        string userInput = Console.ReadLine();
        int points = int.Parse(userInput);

        if (answer == 1)
        {
            SimpleGoal simpleGoal = new(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (answer == 2)
        {
            EternalGoal eternalGoal = new(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (answer == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
            string input = Console.ReadLine();
            int timeLapse = int.Parse(input);
            Console.Write("What is the bonus for accomplishing it that many times?  ");
            input = Console.ReadLine();
            int bonusPoints = int.Parse(input);

            ChecklistGoal checklistGoal = new(name, description, points, timeLapse, bonusPoints);
            _goals.Add(checklistGoal);
        } 

    }
    public void RecordEvent()
    {
        ListGoalNames();

        if (_goals.Count == 0)
        {   
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are any available goals to record");
            Console.ResetColor();
            return;
        }

        Console.Write("Which goal did you accomplish?  ");
        string userInput = Console.ReadLine();
        int recordGoal = int.Parse(userInput);
        recordGoal--; 
        
        int points = _goals[recordGoal].RecordEvent(); 
        _score += points;

        DisplayAnimation();

        Console.WriteLine($"You have earned {points} points!");

        DisplayPlayerInfo();
    }

    public void SaveGoals()
    {
        Console.Write("Enter the name of the file:  ");
        string fileName = Console.ReadLine();

        using StreamWriter outputFile = new StreamWriter(fileName);
        outputFile.WriteLine(_score);

        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }

        Console.WriteLine("Your file has been saved");
    }
    public void LoadGoals()
    {
        string firstString;
        string secondString;

        Console.Write("Enter the name of the file to open:  ");
        string fileName = Console.ReadLine();


        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        
        foreach(string line in lines)
        {

            if (line == lines[0]) continue;
            string[] firstLine = line.Split(":");
            firstString = firstLine[0];
            secondString = firstLine[1];
            
            
            string[] secondLine = secondString.Split("|");
            string name = secondLine[0];
            string description = secondLine[1];
            int points = int.Parse(secondLine[2]);
       
            if (firstString == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new(name, description, points);                
                simpleGoal.SetIsComplete(secondLine[3] == "True");
                _goals.Add(simpleGoal);
            }
            else if (firstString == "EternalGoal")
            {
                EternalGoal eternalGoal = new(name, description, points);
                _goals.Add(eternalGoal);
            } 
            else if (firstString == "ChecklistGoal")
            {
                int bonus = int.Parse(secondLine[3]);
                int target = int.Parse(secondLine[4]);
                int amountCompleted = int.Parse(secondLine[5]);
                ChecklistGoal checklistGoal = new(name, description, points, target, bonus);
                checklistGoal.SetAmount(amountCompleted);
                _goals.Add(checklistGoal);
            }
        }
     }

   private static void DisplayAnimation()
   {
       Console.WriteLine();
       for (int i = 0; i < 6; i++)
       {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("★ ");
        Console.ResetColor();
        System.Threading.Thread.Sleep(200);
         
       }
       Console.WriteLine();
       Console.ForegroundColor = ConsoleColor.Cyan;
       Console.WriteLine("Congratulations!");
       Console.ResetColor();
       Console.WriteLine();
   }

}
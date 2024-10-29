using System.IO;
public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    private int _score;

    public void AddPoints(int points)
    {
        _score += points;
    }

    public void Start()
    {
        bool startQuest = true;
        while (startQuest)
        {
            Console.WriteLine($"\nYou have {_score} points\n");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    startQuest = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please, try again.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
    
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;
        switch (goalType)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal creation canceled.");
                return;
        }
        goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!\n");
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        //Console.WriteLine($"Current Score: {_score}");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? :");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            Console.WriteLine($"Congratulations! You have earned {goals[index].RecordEvent(this)}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!\n");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                            goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            var eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            goals.Add(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6])); 
                            goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
using internship_assignment;
using System;


// first problem
void AnalogueClockProblem()
{
    Console.WriteLine("Insert hours 0-12");
    int hours = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert minutes 0-60");
    int minutes = int.Parse(Console.ReadLine());

    // valid check
    if(hours < 0 || hours>11 || minutes<0 || minutes > 59)
    {
        Console.WriteLine("Invalid input");
        return;
    }

    // hours / 12 gets value between 0-1, multiplied by 360 gives angle
    float angleHours = (float) hours / 12 * 360;
    // similar for minutes
    float angleMinutes = (float) minutes / 60 * 360;

    float relativeAngle = Math.Abs(angleHours - angleMinutes);
    Console.WriteLine($"Lesser angle between hours and minutes is {Math.Min(relativeAngle,360-relativeAngle)}");
}

// second and third problem
void TreeProblem()
{
    Tree tree = new Tree();
    tree.GenerateTree();
    Console.WriteLine($"Depth of the tree is {tree.GetDepth()}");
}

AnalogueClockProblem();
TreeProblem();
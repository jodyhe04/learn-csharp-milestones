using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int i = 1;
    private string str = "This is a string";
    private float f = i;
    private bool b;
    // Start is called before the first frame update
    void Start()
    {
        Update(); 
        // create int string float and bool variables

    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(str + "string");
       Debug.log($"This is not a string");

    }
    using System;

public class Chapter3
{
    static string GetGreeting(string name)
    {
        return "Hello, " + name + "!";
    }

    static void Main(string[] args)
    {
        string greeting = GetGreeting("Alice");
        Console.WriteLine(greeting);
        Console.WriteLine(GetGreeting("Bob"));
    }
}
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public bool isPlayerAlive = true;
    public int score = 50;
    public string difficulty = "Medium";

    void Start()
    {
        if (score > 100)
        {
            Debug.Log("You have a high score!");
        }
        else if (score > 50)
        {
            Debug.Log("Your score is decent.");
        }
        else
        {
            Debug.Log("Keep trying to increase your score.");
        }

        if (isPlayerAlive)
        {
            Debug.Log("Player is alive.");
        }
        else
        {
            Debug.Log("Player is not alive.");
        }

        if (isPlayerAlive)
        {
            if (score > 30)
            {
                Debug.Log("Player is alive and has a good score.");
            }
        }

        switch (difficulty)
        {
            case "Easy":
                Debug.Log("Difficulty: Easy.");
                break;
            case "Medium":
                Debug.Log("Difficulty: Medium.");
                break;
            case "Hard":
                Debug.Log("Difficulty: Hard.");
                break;
            default:
                Debug.Log("Unknown difficulty.");
                break;
        }


        Character hero = new Character("Hero", 10);
        Character heroine = new Character("Heroine", 8);

        
        Debug.Log($"Hero: Name = {hero.name}, Level = {hero.level}");
        Debug.Log($"Heroine: Name = {heroine.name}, Level = {heroine.level}");

 
        Character.Weapon huntingBow = new Character.Weapon("Hunting Bow", 20);
        Character.Weapon warBow = new Character.Weapon("War Bow", 40);

        Debug.Log("Weapon: " + huntingBow.name + ", Damage: " + huntingBow.damage);
        Debug.Log("Weapon: " + warBow.name + ", Damage: " + warBow.damage);
    }
}

    }
}

    }
}
public class LearningCurve
{
    public static void Main()
    {
        int[] scores = { 100, 200, 300 };
        Console.WriteLine("The second score in the array is: " + scores[1]);

        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        Console.WriteLine("The first fruit in the list is: " + fruits[0]);

        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("Sword", 1);
        inventory.Add("Shield", 2);
        Console.WriteLine("You have " + inventory["Shield"] + " shields in your inventory.");
    }
}

public class Character
{
    public string name;
    public int level;
    public Character(string charName, int charLevel)
    {
        name = charName;
        level = charLevel;
    }

     public struct Weapon
    {
        public string name; 
        public int damage; 
        public Weapon(string weaponName, int weaponDamage)
        {
            name = weaponName;
            damage = weaponDamage;
        }
    }
}

}

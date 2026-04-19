using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

public class habitmanager : MonoBehaviour
{
    //Manages all habits and handles saving/loading
    public List<Habit> habits = new List<Habit>();
    // Start is called before the first frame update
    void Start()
    {
        //On startup, add the Drink Water habit
        habits.Add(new Habit("Drink Water"));
        habits.Add(new Habit("Empty"));
        habits.Add(new Habit("Empty"));
        habits[1].isEmpty = true;
        habits[2].isEmpty = true;

        LoadAll();
    }

    public void IncreaseHabit1()
    {
        habits[0].IncreaseProgress(5);
        SaveAll();
    }
    public void DecreaseHabit1()
    {
        habits[0].DecreaseProgress(5);
        SaveAll();
    }

    public void IncreaseHabit2()
    {
        habits[1].IncreaseProgress(5);
        SaveAll();
    }
    public void DecreaseHabit2()
    {
        habits[1].DecreaseProgress(5);
        SaveAll();
    }
    
    public void IncreaseHabit3()
    {
        habits[2].IncreaseProgress(5);
        SaveAll();
    }
    public void DecreaseHabit3()
    {
        habits[2].DecreaseProgress(5);
        SaveAll();
    }

    public Habit GetHabit(int index)
    //Method to return specific habits
    {
        if (index >= 0 && index < habits.Count)
        {
            return habits[index];
        }
        return null;
    }


    public void CreateHabit1(string name)
    {
        habits[0] = new Habit(name);
        SaveAll();
    }

    public void DeleteHabit1()
    {
        habits[0].isEmpty = true;
        habits[0].progress = 0;
        SaveAll();
    }

    public void CreateHabit2(string name)
    {
        habits[1] = new Habit(name);
        SaveAll();
    }

    public void DeleteHabit2 ()
    {
        habits[1].isEmpty = true;
        habits[1].progress = 0;
        SaveAll();
    }

    public void CreateHabit3(string name)
    {
        habits[2] = new Habit(name);
        SaveAll();
    }

    public void DeleteHabit3()
    {
        habits[2].isEmpty = true;
        habits[2].progress = 0;
        SaveAll();
    }

    void SaveAll()
    {
        for (int i = 0; i < habits.Count; i++)
        {
            PlayerPrefs.SetString($"habit_name_{i}", habits[i].name);
            PlayerPrefs.SetInt($"habit_progress_{i}", habits[i].progress);
            PlayerPrefs.SetInt($"habit_empty_{i}", habits[i].isEmpty ? 1 : 0);
        }

        PlayerPrefs.Save();
    }

    void LoadAll()
    {
        for (int i = 0; i < habits.Count; i++)
        {
            string name = PlayerPrefs.GetString($"habit_name_{i}", "Empty");
            int progress = PlayerPrefs.GetInt($"habit_progress_{i}", 0);
            bool isEmpty = PlayerPrefs.GetInt($"habit_empty_{i}", 1) == 1;
            habits[i].name = name;
            habits[i].progress = progress;
            habits[i].isEmpty = isEmpty;
        }
    }

    void OnApplicationQuit()
    {
        SaveAll();
    }

    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            SaveAll();
        }
    }
}

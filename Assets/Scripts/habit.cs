using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Habit
{
    public string name;
    public int progress;
    public bool isEmpty = false;

    public Habit(string name)
    {
        this.name = name;
        this.progress = 0;
    }

    public void IncreaseProgress(int amount)
    {
        progress += amount;
        if (progress > 100)
        {
            progress = 100;
        }
    }

    public void DecreaseProgress(int amount)
    {
        progress -= amount;
        if (progress < 0)
        {
            progress = 0;
        }
    }

}

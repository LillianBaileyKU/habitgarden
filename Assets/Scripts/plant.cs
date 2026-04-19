using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using Microsoft.Unity.VisualStudio.Editor;
#endif
using UnityEngine;
using UnityEngine.UI;

public class plant : MonoBehaviour
{
    //Controls visual growth of the plants
    public habitmanager manager;
    public int habitIndex = 0;
    public List<UnityEngine.UI.Image> leaves = new List<UnityEngine.UI.Image>();

    // Update is called once per frame
    void Update()
    {
        Habit habit = manager.GetHabit(habitIndex);
        if (habit != null)
        {
            if (habit.isEmpty == true)
            {
                leaves[0].enabled = false;
                leaves[1].enabled = false;
                leaves[2].enabled = false;
                leaves[3].enabled = false;
                leaves[4].enabled = false;
                leaves[5].enabled = false;
            }
            else if (habit.progress < 10)
            {
                leaves[0].enabled = true;
                leaves[1].enabled = false;
                leaves[2].enabled = false;
                leaves[3].enabled = false;
                leaves[4].enabled = false;
                leaves[5].enabled = false;
                Debug.Log("Printed at less than 10");
            }
            else if (habit.progress >= 10 && habit.progress < 20)
            {
                leaves[0].enabled = true;
                leaves[1].enabled = true;
                leaves[2].enabled = false;
                leaves[3].enabled = false;
                leaves[4].enabled = false;
                leaves[5].enabled = false;
                Debug.Log("Printed at less than 20");
            }
            else if (habit.progress >= 20 && habit.progress < 40)
            {
                leaves[0].enabled = true;
                leaves[1].enabled = true;
                leaves[2].enabled = true;
                leaves[3].enabled = false;
                leaves[4].enabled = false;
                leaves[5].enabled = false;
                Debug.Log("Printed at less than 40");
            }
            else if (habit.progress >= 40 && habit.progress < 60)
            {
                leaves[0].enabled = true;
                leaves[1].enabled = true;
                leaves[2].enabled = true;
                leaves[3].enabled = true;
                leaves[4].enabled = false;
                leaves[5].enabled = false;
                Debug.Log("Printed at less than 60");
            }
            else if (habit.progress >= 60 && habit.progress < 80)
            {
                leaves[0].enabled = true;
                leaves[1].enabled = true;
                leaves[2].enabled = true;
                leaves[3].enabled = true;
                leaves[4].enabled = true;
                leaves[5].enabled = false;
                Debug.Log("Printed at less than 80");
            }
            else if (habit.progress >= 80)
            {
                leaves[0].enabled = true;
                leaves[1].enabled = true;
                leaves[2].enabled = true;
                leaves[3].enabled = true;
                leaves[4].enabled = true;
                leaves[5].enabled = true;
                Debug.Log("Printed at more than 80");
            }

        }
    }
}

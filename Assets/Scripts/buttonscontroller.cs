using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class buttonscontroller : MonoBehaviour
{
    //Controls UI buttons for plant/habit slots
    public habitmanager manager;
    public Button AddButton;
    public Button SubtractButton;
    public Button AddHabitButton;
    public Button DeleteHabitButton;
    public int habitindex;
    public TextMeshProUGUI habittext;


    // Start is called before the first frame update
    void Start()
    {
        plant plantscript = GetComponent<plant>();
        if (plantscript != null)
        {
            habitindex = plantscript.habitIndex;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Show or hide buttons based on plant vacancy
        if (manager.habits[habitindex].isEmpty == true)
        {
            AddButton.gameObject.SetActive(false);
            SubtractButton.gameObject.SetActive(false);
            DeleteHabitButton.gameObject.SetActive(false);
            AddHabitButton.gameObject.SetActive(true);
            habittext.text = $"Current Habit: None";
        }
        else if (manager.habits[habitindex].isEmpty == false)
        {
            AddButton.gameObject.SetActive(true);
            SubtractButton.gameObject.SetActive(true);
            DeleteHabitButton.gameObject.SetActive(true);
            AddHabitButton.gameObject.SetActive(false);
            habittext.text = $"Current Habit: {manager.habits[habitindex].name}";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class addhabituicontroller : MonoBehaviour
{
    public habitmanager manager;
    public GameObject addhabitpanel;
    public TMP_InputField inputfield;
    private int currentslotindex;
    private string currentinput;
    public GameObject tutorialimage;
    private bool firstopen = true;


    public void Start()
    {
        LoadFirst();
        if (firstopen == true)
        {
            tutorialimage.SetActive(true);
            firstopen = false;
            SaveFirst();
        }
    }
    public void OpenAddHabit(int slotindex)
    {
        currentslotindex = slotindex;
        addhabitpanel.SetActive(true);
        inputfield.text = "";
        inputfield.Select();
    }

    public void SubmitHabit()
    {
        currentinput = inputfield.text;
        if (string.IsNullOrWhiteSpace(currentinput))
        {
            return;
        }
        else
        {
            if (currentslotindex == 0)
            {
                manager.CreateHabit1(currentinput);
            }
            else if (currentslotindex == 1)
            {
                manager.CreateHabit2(currentinput);
            }
            else if (currentslotindex == 2)
            {
                manager.CreateHabit3(currentinput);
            }
            inputfield.text = "";
            addhabitpanel.SetActive(false);
        }
    }

    public void CloseTutorial()
    {
        tutorialimage.SetActive(false);
    }

    void LoadFirst()
    {
        firstopen = PlayerPrefs.GetInt("first_run", 0) == 0;
    }

    void SaveFirst()
    {
        PlayerPrefs.SetInt("first_run", 1);
        PlayerPrefs.Save();
    }

}

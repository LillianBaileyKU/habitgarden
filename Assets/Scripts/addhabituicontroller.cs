using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class addhabituicontroller : MonoBehaviour
{
    //Handles UI for adding habits and showing first time tutorial
    public habitmanager manager;
    public GameObject addhabitpanel;
    public TMP_InputField inputfield;
    private int currentslotindex;
    private string currentinput;
    public GameObject tutorialimage;
    private bool firstopen = true;
    public AudioSource audiosource;
    public AudioClip tutorialsound;


    public void Start()
    {
        //Check if user has opened the app before, otherwise play tutorial
        LoadFirst();
        if (firstopen == true)
        {
            tutorialimage.SetActive(true);
            audiosource.PlayOneShot(tutorialsound, 0.8f);
            SaveFirst();
        }
    }
    public void OpenAddHabit(int slotindex)
    //Opens add habit panel
    {
        currentslotindex = slotindex;
        addhabitpanel.SetActive(true);
        inputfield.text = "";
        inputfield.Select();
    }

    public void SubmitHabit()
    {
        //Submits new habit to plant
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
    //Close tutorial, load first run data, save first run data
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
        Debug.Log("Saving first run = 1");
        PlayerPrefs.SetInt("first_run", 1);
        PlayerPrefs.Save();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class clockcontroller : MonoBehaviour
{
    //Controls date/time text
    public TextMeshProUGUI clocktext;
    public TextMeshProUGUI datetext;

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;

        clocktext.text = now.ToString("hh:mm:ss tt");
        datetext.text = now.ToString("dddd, MMMM dd");
    }
}

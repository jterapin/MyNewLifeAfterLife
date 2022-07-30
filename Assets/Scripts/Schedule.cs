using UnityEngine;
using UnityEngine.UI;
using System;


public class Schedule : MonoBehaviour
{
    // creating an array to collect activity choices

    public string[] weeks = new string[4] { "None", "None", "None", "None" };

    void Start()
    {

        foreach (string item in weeks)
        {
            print(item);
        }

    }


}
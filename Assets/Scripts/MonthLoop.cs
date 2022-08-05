using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MonthLoop : MonoBehaviour
{
    public GameObject Panel;
    public CurrentSchedule currentSchedule;
    public ActivityObject[] Schedule;

    public PlayerStat PlayerStat;

    public DialogDisplay DialogText;

    void Start()
    {
        if (!Panel.GetComponent<MonthLoop>().enabled)
        {
            Panel.GetComponent<MonthLoop>().enabled = false;
            Panel.GetComponent<MonthLoop>().enabled = true;
        }
    }

    void OnEnable()
    {
        Schedule = currentSchedule.getSchedule();
        LoopActivity();
    }

    public void LoopActivity()
    {
        DialogText = GameObject.Find("DialogueController").GetComponent<DialogDisplay>();
        DialogText.UpdateText("Day 1....\n");
        Debug.Log(Schedule[0].affectedStat);
        Debug.Log("...... does below work from Player Stat?");
        string thing = Schedule[0].affectedStat.ToString();
        Debug.Log(thing);
        PlayerStat.AddStat(thing, 5);
        // DialogText.UpdateText("You did it!\n");

    }
}

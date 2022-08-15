using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonthStartTrigger : MonoBehaviour
{
    [SerializeField] private Button startMonthButton;
    [SerializeField] private ActivityObject[] schedule;
    [SerializeField] private SchedulePanel schedulePanel;

    void Start()
    {
        startMonthButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        schedule = schedulePanel.getSchedule();
        int count = 0;
        for (int i = 0; i < schedule.Length; i++)
            if (schedule[i] != null)
            {
                count++;
            }
        if (count == 4)
        {
            startMonthButton.interactable = true;
        }
        else
        {
            startMonthButton.interactable = false;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonthLoop : MonoBehaviour
{
    public GameObject Panel;
    public CurrentSchedule currentSchedule;
    public ActivityObject[] Schedule;


    void Start()
    {
        Schedule = currentSchedule.getSchedule();
    }

    void Update()
    {
        Schedule = currentSchedule.getSchedule();
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
}
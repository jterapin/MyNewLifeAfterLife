using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeData : MonoBehaviour
{
    public TMP_Text MonthDisplay;
    public int MonthCount = 1;

    void Start()
    {
        MonthDisplay.text = $"Month {MonthCount}";
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateMonth()
    {
        MonthCount += 1;
        MonthDisplay.text = $"Month {MonthCount}";
    }
}

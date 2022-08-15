using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchedulePanel : MonoBehaviour
{
    public ActivityObject[] weeks = new ActivityObject[4];

    public Sprite defaultIcon;

    void Start()
    {
        RefreshSchedule();
    }

    // Render Activities at Start
    public void RefreshSchedule()
    {
        for (int i = 0; i < weeks.Length; i++)
            if (weeks[i] != null)
            {
                int position = i + 1;
                string str = "Content/CurrentSchedule/Week" + position.ToString() + "/Slot";
                Transform child = transform.Find(str);
                child.transform.GetComponent<Image>().sprite = weeks[i].ActivityIcon;
            }
    }

    // Adding An Activity
    public void AssignActivity(ActivityObject activity)
    {
        for (int i = 0; i < weeks.Length; i++)
            if (weeks[i] == null)
            {
                weeks[i] = activity;
                int position = i + 1;
                string str = "Content/CurrentSchedule/Week" + position.ToString() + "/Slot";
                Transform child = transform.Find(str);
                child.transform.GetComponent<Image>().sprite = activity.ActivityIcon;
                break;
            }
    }

    public void DeleteActivity(int selectedActivityPosition)
    {
        for (int i = 0; i < weeks.Length; i++)
            if (i == selectedActivityPosition)
            {
                weeks[i] = null;
                int position = i + 1;
                string str = "Content/CurrentSchedule/Week" + position.ToString() + "/Slot";
                Transform child = transform.Find(str);
                child.transform.GetComponent<Image>().sprite = defaultIcon;
                break;
            }
    }

    // sending CurrentSchedule to MonthLoop object
    public ActivityObject[] getSchedule()
    {
        return weeks;
    }
}

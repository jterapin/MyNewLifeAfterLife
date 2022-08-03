using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentSchedule : MonoBehaviour
{
    public ActivityObject[] Weeks = new ActivityObject[4];

    public Sprite defaultIcon;

    public ActivityObject selectedActivity;
    void Start()
    { }

    // Adding An Activity
    public void AssignActivity(ActivityObject activity)
    {
        for (int i = 0; i < Weeks.Length; i++)
            if (Weeks[i] == null)
            {
                Weeks[i] = activity;
                int position = i + 1;
                string str = "Week" + position.ToString() + "/Slot";
                Transform child = transform.Find(str);
                child.transform.GetComponent<Image>().sprite = activity.activityIcon;
                break;
            }
    }

    public void DeleteActivity(int selectedActivityPosition)
    {
        for (int i = 0; i < Weeks.Length; i++)
            if (i == selectedActivityPosition)
            {
                Weeks[i] = null;
                int position = i + 1;
                string str = "Week" + position.ToString() + "/Slot";
                Transform child = transform.Find(str);
                child.transform.GetComponent<Image>().sprite = defaultIcon;
                break;
            }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentSchedule : MonoBehaviour
{
    public ActivityObject[] Weeks = new ActivityObject[4];

    public ActivityObject selectedActivity;
    void Start()
    {
        Debug.Log(Weeks);
    }

    // Adding An Activity
    public void AssignActivity(ActivityObject activity)
    {
        for (int i = 0; i < Weeks.Length; i++)
            if (Weeks[i] == null)
            {
                Weeks[i] = activity;
                Transform child = transform.GetChild(i);
                Debug.Log(child.name);
                break;
            }
    }

    public void DeleteActivity(int selectedActivityPosition)
    {
        for (int i = 0; i < Weeks.Length; i++)
            if (i == selectedActivityPosition)
            {
                Weeks[i] = null;
                break;
            }
    }

}

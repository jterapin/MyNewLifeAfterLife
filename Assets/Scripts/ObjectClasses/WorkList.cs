using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WorkList : MonoBehaviour
{
    [SerializeField] private GameObject slotHolder;
    [SerializeField] private WorkObject activityToAdd;
    public List<WorkObject> activities = new List<WorkObject>();
    private GameObject[] slots;

    public void Start()
    {
        // all the slots are stored under slots
        slots = new GameObject[slotHolder.transform.childCount];
        for (int i = 0; i < slotHolder.transform.childCount; i++)
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        RefreshSlots();
    }

    public void RefreshSlots()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            try
            {
                slots[i].transform.GetComponent<Image>().enabled = true;
                slots[i].transform.GetComponent<Image>().sprite = activities[i].ActivityIcon;
            }
            catch
            {
                slots[i].transform.GetComponent<Image>().sprite = null;
                slots[i].transform.GetComponent<Image>().enabled = false;
            }
        }
    }
    // Adding a Work Activity
    public void Add(WorkObject activity)
    {
        activities.Add(activity);
    }

}


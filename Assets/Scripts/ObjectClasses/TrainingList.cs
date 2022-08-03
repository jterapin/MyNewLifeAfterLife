using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TrainingList : MonoBehaviour
{
    [SerializeField] private GameObject slotHolder;
    [SerializeField] private TrainingObject activityToAdd;
    public List<TrainingObject> activities = new List<TrainingObject>();

    private GameObject[] slots;


    public void Start()
    {
        // all the slots are stored under slots
        slots = new GameObject[slotHolder.transform.childCount];
        for (int i = 0; i < slotHolder.transform.childCount; i++)
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        RefreshUI();
    }

    public void RefreshUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            try
            {
                slots[i].transform.GetComponent<Image>().enabled = true;
                slots[i].transform.GetComponent<Image>().sprite = activities[i].activityIcon;
            }
            catch
            {
                slots[i].transform.GetComponent<Image>().sprite = null;
                slots[i].transform.GetComponent<Image>().enabled = false;
            }
        }
    }
    // Adding a Training Activity
    public void Add(TrainingObject activity)
    {
        activities.Add(activity);
    }
}



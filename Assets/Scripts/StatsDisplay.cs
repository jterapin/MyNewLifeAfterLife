using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsDisplay : MonoBehaviour
{
    private Dictionary<string, int> stats = PlayerData.stats;
    [SerializeField] GameObject Panel;
    [SerializeField] TMP_Text stamina;

    private void Start()
    {

        if (!Panel.GetComponent<StatsDisplay>().enabled)
        {
            Panel.GetComponent<StatsDisplay>().enabled = false;
            Panel.GetComponent<StatsDisplay>().enabled = true;
        }
    }

    private void OnEnable()
    {
        UpdateStats();
    }

    private void UpdateStats()
    {

        stamina.text = stats["Stamina"].ToString();
        stamina.text = stats["Stamina"].ToString();
        stamina.text = stats["Stamina"].ToString();
        stamina.text = stats["Stamina"].ToString();
        stamina.text = stats["Stamina"].ToString();
        stamina.text = stats["Stamina"].ToString();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsDisplay : MonoBehaviour
{
    public Dictionary<string, int> stats = PlayerData.stats;
    public TMP_Text nameText;
    public TMP_Text[] staminaDisplays;

    private void Start()
    {
        Debug.Log(stats["Stamina"]);
        staminaDisplays[0].text = stats["Stamina"].ToString();
    }

    private void Validate()
    {

    }

    private void Update()
    {
        staminaDisplays[0].text = stats["Stamina"].ToString();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsPanel : MonoBehaviour
{
    public Dictionary<string, int> stats = PlayerData.stats;
    public TMP_Text nameText;
    public TMP_Text staminaValueText;

    private void Start()
    {
        Debug.Log(stats["Stamina"]);
        staminaValueText.text = stats["Stamina"].ToString();
    }

    private void Validate()
    {

    }

    private void Update()
    {
        staminaValueText.text = stats["Stamina"].ToString();
    }


}

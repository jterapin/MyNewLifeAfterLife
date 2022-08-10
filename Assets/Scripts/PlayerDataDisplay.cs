using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataDisplay : MonoBehaviour
{
    public Dictionary<string, int> stats = PlayerData.stats;
    public TMP_Text nameText;
    public TMP_Text staminaValueText;

    private void onUpdate()
    {
        staminaValueText.text = stats["Stamina"].ToString();
    }




}

using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerName = "Player";
    public Dictionary<string, int> stats = new Dictionary<string, int>()
    {
        {"Stamina",0},
        {"Strength", 0},
        {"Agility", 0},
        {"Stress", 0},
    };

    public void AddStat(string stat, int num)
    {
        try
        {
            stats[stat] += num;
        }
        catch
        {
            Debug.Log("No such Stat is present");
        }
    }

}

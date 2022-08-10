using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerName = "Player";
    public string previousLife = "";
    public string starSign = "";
    public Dictionary<string, int> stats = new Dictionary<string, int>()
    {
        {"Stamina",0},
        {"Strength", 0},
        {"Agility", 0},
        {"Magic", 0},
        {"Charisma", 0},
        {"Luck", 0},
        {"Stress", 0},
        {"Gold", 0},
    };
    public Dictionary<string, int> skills = new Dictionary<string, int>()
    {
        {"Sword",0},
        {"Archery", 0},
        {"Cooking", 0},
        {"Fishing", 0},
        {"Alchemy", 0},
        {"Dark Magic", 0},
        {"Light Magic", 0},
        {"World Lore", 0},
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

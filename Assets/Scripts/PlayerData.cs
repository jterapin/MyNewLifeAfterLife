using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerName = "Player";
    public string previousLife = "";
    public string starSign = "";
    public static Dictionary<string, int> stats = new Dictionary<string, int>()
    {
        {"Stamina",5},
        {"Strength", 0},
        {"Agility", 0},
        {"Magic", 0},
        {"Charisma", 0},
        {"Luck", 0},
        {"Stress", 0},
        {"Gold", 0},
    };
    public static Dictionary<string, int> skills = new Dictionary<string, int>()
    {
        {"Sword",5},
        {"Archery", 0},
        {"Cooking", 0},
        {"Fishing", 0},
        {"Alchemy", 0},
        {"Dark Magic", 0},
        {"Light Magic", 0},
        {"World Lore", 0},
    };

    public void IncreaseStat(string stat, int statNum, int stressNum)
    {
        try
        {
            stats[stat] += statNum;
            stats["Stress"] += stressNum;
        }
        catch
        {
            Debug.Log("No such Stat is present");
        }
    }
    public void IncreaseSkill(string skill, int skillNum)
    {
        try
        {
            skills[skill] += skillNum;
        }
        catch
        {
            Debug.Log("No such Skill is present");
        }
    }
    public void IncreaseGold(int goldAmt)
    {
        try
        {
            stats["Gold"] += goldAmt;
        }
        catch
        {
            Debug.Log("Gold Doesn't Exist!");
        }
    }

    public void DecreaseStress(int stressNum)
    {
        try
        {
            stats["Stress"] -= stressNum;
            if (stats["Stress"] < 0)
            {
                stats["Stress"] = 0;
            }
        }
        catch
        {
            Debug.Log("Stress Doesn't Exist!");
        }
    }



}

using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static string playerName = "";
    public static Sprite playerSprite;
    public Animator activityAnimator;
    public Animator roomAnimator;
    public static RuntimeAnimatorController newController;

    public static Dictionary<string, int> stats = new Dictionary<string, int>()
    {
        {"Stamina", 0},
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
        {"Sword", 0},
        {"Archery", 0},
        {"Cooking", 0},
        {"Fishing", 0},
        {"Alchemy", 0},
        {"DarkMagic", 0},
        {"LightMagic", 0},
        {"WorldLore", 0},
    };

    void Start()
    {
        SetAnimator();
        Debug.Log(playerName);

    }

    public void SetAnimator()
    {
        activityAnimator.runtimeAnimatorController = newController;
        roomAnimator.runtimeAnimatorController = newController;
    }

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

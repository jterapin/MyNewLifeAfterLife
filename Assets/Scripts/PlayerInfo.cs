using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public string PlayerName = "Player";
    public Dictionary<string, int> stats = new Dictionary<string, int>()
    {
        {"Stamina",0},
        {"Strength", 0},
        {"Agility", 0},
        {"Stress", 0},
    };

    public ActivityObject Activity;


    void Start()
    {

    }

    void Update()
    {

    }

    public void AddStat(string stat, int num)
    {
        try
        {
            Debug.Log(stats[stat]);
            stats[stat] += num;
            Debug.Log(stats[stat]);
        }
        catch
        {
            Debug.Log("No such key present");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public string PlayerName = "Player";
    Dictionary<string, int> stats = new Dictionary<string, int>()
    {
        {"Stamina",0},
        {"Strength", 0},
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
        Debug.Log("Clicked!");
        // Debug.Log(stat);
        // Debug.Log(stats[stat]);
        try
        {
            Debug.Log(stat);
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

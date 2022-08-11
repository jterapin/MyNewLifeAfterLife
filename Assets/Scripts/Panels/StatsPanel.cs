using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsPanel : MonoBehaviour
{
    private Dictionary<string, int> stats = PlayerData.stats;
    [SerializeField] TMP_Text stamina;
    [SerializeField] GameObject Panel;

    private void Start()
    {

        if (!Panel.GetComponent<ActivityPanel>().enabled)
        {
            Panel.GetComponent<ActivityPanel>().enabled = false;
            Panel.GetComponent<ActivityPanel>().enabled = true;
        }
    }

    private void OnValidate()
    {
        Transform child = transform.Find("MiddleContent/StatsBox/Stamina/Value");
        stamina = child.GetComponent<TMP_Text>();
        Debug.Log(stamina);

    }

    private void OnEnable()
    {
        Update();
    }

    private void Update()
    {
        stamina.text = stats["Stamina"].ToString();
    }


}

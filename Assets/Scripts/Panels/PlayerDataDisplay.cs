using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataDisplay : MonoBehaviour
{
    private Dictionary<string, int> statsDict = PlayerData.stats;
    private Dictionary<string, int> skillsDict = PlayerData.skills;

    // Stats
    [Header("Stats")]
    [SerializeField] private TMP_Text stamina;
    [SerializeField] private TMP_Text strength;
    [SerializeField] private TMP_Text agility;
    [SerializeField] private TMP_Text magic;
    [SerializeField] private TMP_Text charisma;
    [SerializeField] private TMP_Text luck;
    [SerializeField] private TMP_Text stress;
    [SerializeField] private TMP_Text gold;

    // Skills
    [Header("Skills")]
    [SerializeField] private TMP_Text sword;
    [SerializeField] private TMP_Text archery;
    [SerializeField] private TMP_Text cooking;
    [SerializeField] private TMP_Text fishing;
    [SerializeField] private TMP_Text alchemy;
    [SerializeField] private TMP_Text darkMagic;
    [SerializeField] private TMP_Text lightMagic;
    [SerializeField] private TMP_Text worldLore;

    private void OnEnable()
    {
        UpdateStats();
        UpdateSkills();
    }

    private void Update()
    {
        UpdateStats();
        UpdateSkills();
    }

    private void UpdateStats()
    {
        stamina.text = statsDict["Stamina"].ToString();
        strength.text = statsDict["Strength"].ToString();
        agility.text = statsDict["Agility"].ToString();
        magic.text = statsDict["Magic"].ToString();
        charisma.text = statsDict["Charisma"].ToString();
        luck.text = statsDict["Luck"].ToString();
        stress.text = statsDict["Stress"].ToString();
        gold.text = statsDict["Gold"].ToString();
    }

    private void UpdateSkills()
    {
        sword.text = skillsDict["Sword"].ToString();
        archery.text = skillsDict["Archery"].ToString();
        cooking.text = skillsDict["Cooking"].ToString();
        fishing.text = skillsDict["Fishing"].ToString();
        alchemy.text = skillsDict["Alchemy"].ToString();
        darkMagic.text = skillsDict["Dark Magic"].ToString();
        lightMagic.text = skillsDict["Light Magic"].ToString();
        worldLore.text = skillsDict["World Lore"].ToString();
    }


}

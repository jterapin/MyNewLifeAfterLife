using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "PlayerSelectionObject")]
public class PlayerSelectionObject : ScriptableObject
{
    public string playerName = "";
    public string playerSprite = "";
}

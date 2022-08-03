using UnityEngine;

[CreateAssetMenu(fileName = "New Activity", menuName = "Custom Objects/Activity/Work")]
public class WorkObject : ActivityObject
{
    public int goldEarning;
    public int goldEarningBonus;
    public void Awake()
    {
        type = ActivityType.Work;
    }
}

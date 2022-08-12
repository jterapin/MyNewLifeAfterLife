using UnityEngine;

[CreateAssetMenu(fileName = "New Activity", menuName = "Custom Objects/Activity/Work")]
public class WorkObject : ActivityObject
{
    public void Awake()
    {
        Type = ActivityType.Work;
    }
}

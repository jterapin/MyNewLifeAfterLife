using UnityEngine;

[CreateAssetMenu(fileName = "New Activity", menuName = "Custom Objects/Activity/Rest")]
public class RestObject : ActivityObject
{
    public void Awake()
    {
        type = ActivityType.Rest;
    }
}

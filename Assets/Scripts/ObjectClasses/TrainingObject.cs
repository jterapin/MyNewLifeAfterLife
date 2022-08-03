using UnityEngine;

[CreateAssetMenu(fileName = "New Activity", menuName = "Custom Objects/Activity/Training")]

public class TrainingObject : ActivityObject
{
    public void Awake()
    {
        type = ActivityType.Training;
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "New Activity", menuName = "Custom Objects/Activity/Training")]

public class TrainingObject : ActivityObject
{
    public PlayerStat PlayerStat;
    public int IncreasingAmt;

    public string SuccessMessage = "Success!";

    public void Awake()
    {
        type = ActivityType.Training;
    }

    public void Chance()
    {
        int digit = Random.Range(0, 2);
        if (digit == 0)
        {
        }
    }

}

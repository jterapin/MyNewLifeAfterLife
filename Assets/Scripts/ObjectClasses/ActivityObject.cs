using UnityEngine;

// outline of Activity Types
public enum ActivityType
{
    Training,
    Work,
    Rest
}

public enum AffectedStat
{
    Stamina,
    Agility,
    Magic,
    None
}

public abstract class ActivityObject : ScriptableObject
{
    public string activityName;
    public Sprite activityIcon;
    public ActivityType type;

    // Easier to read description in the Unity Editor
    [TextArea(15, 20)]
    public string description;

    public string Animation;
    public string animationSuccess;
    public string animationFailure;

    public AffectedStat affectedStat;
    public int statSuccessValue;
    public int statFailureValue;
    public int stressSuccessValue;
    public int stressFailureValue;
    public string activityMessage;
    public string successMessage = "";
    public string failureMessage = "";


}

using UnityEngine;

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
    [TextArea(15, 15)]
    public string description;

    // Animation variables
    public string activityAnimation;
    public string animationSuccess;
    public string animationFailure;

    // Stats variables
    public AffectedStat affectedStat;
    public int statSuccessValue;
    public int statFailureValue;
    public int stressSuccessValue;
    public int stressFailureValue;

    // Message variables
    public string activityMessage;
    public string successMessage;
    public string failureMessage;


}

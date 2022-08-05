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
    Strength,
    Agility,
    None
}

public abstract class ActivityObject : ScriptableObject
{
    public string activityName;
    public Sprite activityIcon;
    public ActivityType type;

    public AffectedStat affectedStat;

    // Easier to read description in the Unity Editor
    [TextArea(15, 20)]
    public string description;



}

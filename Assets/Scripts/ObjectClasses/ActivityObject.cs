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
    Strength,
    Agility,
    Magic,
    Charisma,
    Luck,
    None
}

public enum AffectedSkill
{
    Sword,
    Archery,
    Cooking,
    Fishing,
    DarkMagic,
    LightMagic,
    WorldLore,
    None
}


public abstract class ActivityObject : ScriptableObject
{
    public string ActivityName;
    public Sprite ActivityIcon;
    public ActivityType Type;

    // Easier to read description in the Unity Editor
    [TextArea(5, 5)]
    [SerializeField] private string description;

    [Header("Animation")]
    public string ActivityAnimation;
    public string AnimationSuccess;
    public string AnimationFailure;

    [Header("Stats")]
    // Stats variables
    public AffectedStat AffectedStat;
    public int StatSuccessValue;
    public int StatFailureValue;
    public int StressSuccessValue;
    public int StressFailureValue;

    [Header("Skills")]
    public AffectedSkill AffectedSkill;
    public int SkillSuccessValue;
    public int SkillFailureValue;

    [Header("Other")]
    public int GoldEarned;
    public int GoldCost;
    public int StressValue;

    [Header("Messages")]
    // Message variables
    public string ActivityMessage;
    public string SuccessMessage;
    public string FailureMessage;


}

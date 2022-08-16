using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityPanel : MonoBehaviour
{
    private Dictionary<string, int> statsDict = PlayerData.stats;
    [SerializeField] private GameObject Panel;
    [SerializeField] private SchedulePanel schedulePanel;
    [SerializeField] private ActivityObject[] schedule;
    private PlayerData playerData;
    private ActivityLogDisplay activityLog;
    private Animator animator;
    [SerializeField] private TimeData time;

    [SerializeField] private Button backButton;

    void Start()
    {
        if (!Panel.GetComponent<ActivityPanel>().enabled)
        {
            Panel.GetComponent<ActivityPanel>().enabled = false;
            Panel.GetComponent<ActivityPanel>().enabled = true;
        }
    }

    void OnEnable()
    {
        activityLog.ClearText();
        schedule = schedulePanel.getSchedule();
        backButton.interactable = false;
        StartCoroutine(ActivityLoop());
    }

    private void Awake()
    {
        activityLog = GameObject.Find("ActivityLogController").GetComponent<ActivityLogDisplay>();
        playerData = GameObject.Find("PlayerController").GetComponent<PlayerData>();
        animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    public bool isActivitySuccessful(string affectedStat)
    {
        // example scenario
        // strength is at 30 so the bonus will be 15
        // stress is at 20 so the penalty is 10
        // normal chance at 50 + 15 = 65% success 
        // 65 - 10 = 55% success due to stress
        int digit = UnityEngine.Random.Range(0, 101);
        int bonusFromStat = statsDict[affectedStat] / 2;
        int penaltyFromStress = statsDict["Stress"] / 2;
        int chance = (50 + bonusFromStat) - penaltyFromStress;
        if (digit <= chance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public IEnumerator ActivityLoop()
    {
        for (int i = 0; i < schedule.Length; i++)
        {
            // Announce the Current Week before Activity
            activityLog.UpdateText($"Week {i + 1}....\n");

            // Training Activity Route
            if (schedule[i] is TrainingObject)
            {
                yield return new WaitForSeconds(2);
                string affectedStat = schedule[i].AffectedStat.ToString();
                activityLog.UpdateText($"Starting {schedule[i].ActivityName}...\n");
                activityLog.UpdateText($"{schedule[i].ActivityMessage}\n");
                animator.SetTrigger(schedule[i].ActivityAnimation);
                yield return new WaitForSeconds(1);
                bool ActivitySuccess = isActivitySuccessful(affectedStat);
                if (ActivitySuccess == true)
                // Success Route
                {
                    animator.SetTrigger(schedule[i].AnimationSuccess);
                    yield return new WaitForSeconds(2);
                    activityLog.UpdateText($"{schedule[i].SuccessMessage}\n");
                    activityLog.UpdateText($"Gained {schedule[i].StatSuccessValue} {affectedStat}\n");
                    if (schedule[i].AffectedSkill != AffectedSkill.None)
                    {
                        string affectedSkill = schedule[i].AffectedSkill.ToString();
                        activityLog.UpdateText($"Gained {schedule[i].SkillSuccessValue} {affectedSkill}\n");
                        playerData.IncreaseSkill(affectedSkill, schedule[i].SkillSuccessValue);
                    }
                    activityLog.UpdateText($"Gained {schedule[i].StressSuccessValue} Stress\n");
                    playerData.IncreaseStat(affectedStat, schedule[i].StatSuccessValue, schedule[i].StressSuccessValue);
                }
                else
                // Failure Route
                {
                    animator.SetTrigger(schedule[i].AnimationFailure);
                    yield return new WaitForSeconds(2);
                    activityLog.UpdateText($"{schedule[i].FailureMessage}\n");
                    activityLog.UpdateText($"Gained {schedule[i].StatFailureValue} {affectedStat}\n");
                    if (schedule[i].AffectedSkill != AffectedSkill.None)
                    {
                        string affectedSkill = schedule[i].AffectedSkill.ToString();
                        activityLog.UpdateText($"Gained {schedule[i].SkillFailureValue} {affectedSkill}\n");
                        playerData.IncreaseSkill(affectedSkill, schedule[i].SkillFailureValue);
                    }
                    activityLog.UpdateText($"Gained {schedule[i].StressFailureValue} Stress\n");
                    playerData.IncreaseStat(affectedStat, schedule[i].StatFailureValue, schedule[i].StressFailureValue);
                }
            }
            // Work Activity Route
            else if (schedule[i] is WorkObject)
            {
                yield return new WaitForSeconds(2);
                string affectedStat = schedule[i].AffectedStat.ToString();
                activityLog.UpdateText($"Starting {schedule[i].ActivityName}...\n");
                activityLog.UpdateText($"{schedule[i].ActivityMessage}\n");
                animator.SetTrigger(schedule[i].ActivityAnimation);
                yield return new WaitForSeconds(1);
                bool ActivitySuccess = isActivitySuccessful(affectedStat);
                if (ActivitySuccess == true)
                // Success Route
                {
                    animator.SetTrigger(schedule[i].AnimationSuccess);
                    yield return new WaitForSeconds(2);
                    activityLog.UpdateText($"{schedule[i].SuccessMessage}\n");
                    activityLog.UpdateText($"Gained {schedule[i].StatSuccessValue} {affectedStat}\n");
                    if (schedule[i].AffectedSkill != AffectedSkill.None)
                    {
                        string affectedSkill = schedule[i].AffectedSkill.ToString();
                        Debug.Log(affectedSkill);
                        activityLog.UpdateText($"Gained {schedule[i].SkillSuccessValue} {affectedSkill}\n");
                        playerData.IncreaseSkill(affectedSkill, schedule[i].SkillSuccessValue);
                    }
                    activityLog.UpdateText($"Gained {schedule[i].StressSuccessValue} Stress\n");
                    playerData.IncreaseStat(affectedStat, schedule[i].StatSuccessValue, schedule[i].StressSuccessValue);
                    int goldEarned = schedule[i].GoldEarned;
                    playerData.IncreaseGold(goldEarned);
                }
                else
                // Failure Route
                {
                    animator.SetTrigger(schedule[i].AnimationFailure);
                    yield return new WaitForSeconds(2);
                    activityLog.UpdateText($"{schedule[i].FailureMessage}\n");
                    activityLog.UpdateText($"Gained {schedule[i].StatFailureValue} {affectedStat}\n");
                    if (schedule[i].AffectedSkill != AffectedSkill.None)
                    {
                        string affectedSkill = schedule[i].AffectedSkill.ToString();
                        activityLog.UpdateText($"Gained {schedule[i].SkillFailureValue} {affectedSkill}\n");
                        playerData.IncreaseSkill(affectedSkill, schedule[i].SkillFailureValue);
                    }
                    activityLog.UpdateText($"Gained {schedule[i].StressFailureValue} Stress\n");
                    playerData.IncreaseStat(affectedStat, schedule[i].StatFailureValue, schedule[i].StressFailureValue);
                    int goldEarned = schedule[i].GoldEarned / 2;
                    playerData.IncreaseGold(goldEarned);
                }
            }
            else
            {
                yield return new WaitForSeconds(2);
                activityLog.UpdateText($"Starting {schedule[i].ActivityName}...\n");
                animator.SetTrigger(schedule[i].ActivityAnimation);
                activityLog.UpdateText($"{schedule[i].ActivityMessage}\n");
                yield return new WaitForSeconds(1);
                activityLog.UpdateText($"{schedule[i].StressValue} Stress went down! \n");
                playerData.DecreaseStress(schedule[i].StressValue);

            }
            yield return new WaitForSeconds(1);
        }
        // Reset ActivityLog here
        backButton.interactable = true;
        time.UpdateMonth();

    }



}

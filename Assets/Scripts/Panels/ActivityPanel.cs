using System.Collections;
using UnityEngine;

public class ActivityPanel : MonoBehaviour
{
    public GameObject Panel;
    public SchedulePanel schedulePanel;
    public ActivityObject[] Schedule;
    public PlayerData Player;
    public ActivityLogDisplay ActivityLog;
    private Animator animator;

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
        Schedule = schedulePanel.getSchedule();
        StartCoroutine(ActivityLoop());
    }

    private void Awake()
    {
        ActivityLog = GameObject.Find("ActivityLogController").GetComponent<ActivityLogDisplay>();
        animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    // public bool isActivitySuccessful()
    // {
    //     int digit = UnityEngine.Random.Range(0, 2);
    //     if (digit == 0)
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }

    public IEnumerator ActivityLoop()
    {
        for (int i = 0; i < Schedule.Length; i++)
        {
            if (Schedule[i] is TrainingObject)
            {
                string affectedStat = Schedule[0].affectedStat.ToString();
                yield return new WaitForSeconds(2);
                ActivityLog.UpdateText($"Week {i + 1}....\n");
                ActivityLog.UpdateText($"Starting {Schedule[i].activityName}...\n");
                animator.SetTrigger(Schedule[i].activityAnimation);
                yield return new WaitForSeconds(1);
                // bool ActivitySuccess = isActivitySuccessful();
                bool ActivitySuccess = true;
                if (ActivitySuccess == true)
                {
                    animator.SetTrigger(Schedule[i].animationSuccess);
                    yield return new WaitForSeconds(1);
                    ActivityLog.UpdateText($"{Schedule[i].successMessage}\n");
                    ActivityLog.UpdateText($"Gained {Schedule[i].statSuccessValue} {affectedStat}\n");
                    Player.AddStat(affectedStat, Schedule[i].statSuccessValue);
                    Debug.Log(PlayerData.stats[affectedStat]);
                }
                else
                {
                    animator.SetTrigger(Schedule[i].animationFailure);
                    yield return new WaitForSeconds(1);
                    ActivityLog.UpdateText($"{Schedule[i].failureMessage}\n");
                }
            }
            else
            {
                Debug.Log("Activity is not Training Object!");
                yield return new WaitForSeconds(2);
                ActivityLog.UpdateText($"Week {i + 1}....\n");
                ActivityLog.UpdateText($"Starting {Schedule[i].activityName}...\n");
                animator.SetTrigger(Schedule[i].activityAnimation);
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(2);
            Debug.Log("I waited!");
        }
        // Reset ActivityLog here

    }



}

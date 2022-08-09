using System.Collections;
using UnityEngine;

public class ActivityPanel : MonoBehaviour
{
    public GameObject Panel;
    public CurrentSchedule currentSchedule;
    public ActivityObject[] Schedule;
    public PlayerInfo Player;
    public LogDisplay LogText;
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
        Schedule = currentSchedule.getSchedule();
        StartCoroutine(ActivityLoop());
    }

    private void Awake()
    {
        LogText = GameObject.Find("LogController").GetComponent<LogDisplay>();
        animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    public bool isActivitySuccessful()
    {
        int digit = UnityEngine.Random.Range(0, 2);
        if (digit == 0)
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
        for (int i = 0; i < Schedule.Length; i++)
        {
            if (Schedule[i] is TrainingObject)
            {
                string affectedStat = Schedule[0].affectedStat.ToString();
                yield return new WaitForSeconds(2);
                LogText.UpdateText($"Week {i + 1}....\n");
                LogText.UpdateText($"Starting {Schedule[i].activityName}...\n");
                animator.SetTrigger(Schedule[i].activityAnimation);
                yield return new WaitForSeconds(1);
                bool ActivitySuccess = isActivitySuccessful();
                if (ActivitySuccess == true)
                {
                    animator.SetTrigger(Schedule[i].animationSuccess);
                    yield return new WaitForSeconds(1);
                    LogText.UpdateText($"{Schedule[i].successMessage}\n");
                    LogText.UpdateText($"Gained {Schedule[i].statSuccessValue} {affectedStat}\n");
                    Player.AddStat(affectedStat, Schedule[i].statSuccessValue);
                    Debug.Log(Player.stats[affectedStat]);
                }
                else
                {
                    animator.SetTrigger(Schedule[i].animationFailure);
                    yield return new WaitForSeconds(1);
                    LogText.UpdateText($"{Schedule[i].failureMessage}\n");
                }
            }
            else
            {
                Debug.Log("Activity is not Training Object!");
                yield return new WaitForSeconds(2);
                LogText.UpdateText($"Week {i + 1}....\n");
                LogText.UpdateText($"Starting {Schedule[i].activityName}...\n");
                animator.SetTrigger(Schedule[i].activityAnimation);
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(2);
            Debug.Log("I waited!");


            // Debug.Log(Schedule[0].affectedStat);
            // Debug.Log("...... does below work from Player Stat?");
            // string thing = Schedule[0].affectedStat.ToString();
            // Debug.Log(thing);
            // Player.AddStat(thing, 5);
            // DialogText.UpdateText("You did it!\n");
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public ActivityLogDisplay ActivityLog;

    private void Awake()
    {
        ActivityLog = GameObject.Find("ActivityLogController").GetComponent<ActivityLogDisplay>();
    }

    private void StartActivity()
    {
        ActivityLog.UpdateText("Time to start my activity!\n");
    }

    private void FinishActivity()
    {
        ActivityLog.UpdateText($"Activity Complete....\n");
    }

    private void AnnounceSuccessResult()
    {
        ActivityLog.UpdateText("Activity SUCCESS!\n");
    }
    private void AnnounceFailureResult()
    {
        ActivityLog.UpdateText("Activity FAILED!\n");
    }

}

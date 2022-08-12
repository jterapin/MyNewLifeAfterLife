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

    private void AnnounceSuccessResult()
    {
        ActivityLog.UpdateText("Activity SUCCESS!\n");
    }
    private void AnnounceFailureResult()
    {
        ActivityLog.UpdateText("Activity FAILED!\n");
    }

}

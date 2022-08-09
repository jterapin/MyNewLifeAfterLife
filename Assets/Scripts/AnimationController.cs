using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public LogDisplay LogText;

    private void Awake()
    {
        LogText = GameObject.Find("LogController").GetComponent<LogDisplay>();
    }

    private void StartActivity()
    {
        LogText.UpdateText("Time to start my activity!\n");
    }

    private void FinishActivity()
    {
        LogText.UpdateText($"Activity Complete....\n");
    }

    private void AnnounceSuccessResult()
    {
        LogText.UpdateText("Activity SUCCESS!\n");
    }
    private void AnnounceFailureResult()
    {
        LogText.UpdateText("Activity FAILED!\n");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public DialogDisplay DialogText;
    private void Awake()
    {
        DialogText = GameObject.Find("DialogueController").GetComponent<DialogDisplay>();
    }

    public void StartActivity()
    {
        DialogText.UpdateText("Time to start my activity!\n");
    }

    public void FinishActivity()
    {
        DialogText.UpdateText($"Activity Complete....\n");
    }

    public void AnnounceSuccessResult()
    {
        DialogText.UpdateText("Activity SUCCESS!\n");
    }
    public void AnnounceFailureResult()
    {
        DialogText.UpdateText("Activity FAILED!\n");
    }

}

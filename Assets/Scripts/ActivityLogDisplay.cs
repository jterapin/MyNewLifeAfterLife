using UnityEngine;
using TMPro;

public class ActivityLogDisplay : MonoBehaviour
{
    public TMP_Text ActivityLog;

    void Start()
    {
        ActivityLog.text = "Hello\n";
    }

    public void UpdateText(string text)
    {
        ActivityLog.text += text;
    }

}

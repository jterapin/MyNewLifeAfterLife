using UnityEngine;
using TMPro;

public class ActivityLogDisplay : MonoBehaviour
{
    public TMP_Text ActivityLog;

    void Start()
    {
        ActivityLog.text = "";
    }

    public void UpdateText(string text)
    {
        ActivityLog.text += text;
    }

    public void ClearText()
    {
        ActivityLog.text = "";
    }
}

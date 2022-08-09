using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LogDisplay : MonoBehaviour
{
    public TMP_Text logText;
    // Start is called before the first frame update
    void Start()
    {
        logText.text = "Hello\n";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText(string text)
    {
        logText.text += text;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DialogDisplay : MonoBehaviour
{
    public TMP_Text dialogText;
    // Start is called before the first frame update
    void Start()
    {
        dialogText.text = "Hello\n";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText(string text)
    {
        dialogText.text += text;
    }

}

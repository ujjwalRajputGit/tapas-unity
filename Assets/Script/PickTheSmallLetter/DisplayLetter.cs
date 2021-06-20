using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayLetter : MonoBehaviour
{
    internal void SetLetter(char letter)
    {
        GetComponent<TMP_Text>().text = letter.ToString().ToUpper();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemainingLetterCount : MonoBehaviour
{
    internal void SetRemaining(int remaining)
    {
        GetComponent<TMP_Text>().text = "x" + remaining;
    }
}

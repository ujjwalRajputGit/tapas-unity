using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class PickTheSmallLetter : MonoBehaviour, IPointerClickHandler, IPointerUpHandler
{
    char _randomLetter;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_randomLetter == GameController._letter)
        {
            GetComponent<TMP_Text>().color = Color.green;
            enabled = false;
            GameController.HandleCorrectLetterClick();
        }
        else
        {
            GetComponent<TMP_Text>().color = Color.red;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (_randomLetter != GameController._letter)
        {
            GetComponent<TMP_Text>().color = Color.white;
        }

    }


//    private void OnEnable() 
//    {
//        int a = Random.Range(0,26);
//        _randomLetter = (char) ('a' + a);
//        GetComponent<TMP_Text>().text = _randomLetter.ToString();
//    }
   
   internal void SetLetter(char letter)
   {
       enabled = true;
       GetComponent<TMP_Text>().color = Color.white;
       _randomLetter = letter;
        GetComponent<TMP_Text>().text = _randomLetter.ToString();
   }
}

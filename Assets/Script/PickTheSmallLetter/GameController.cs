using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static char _letter = 'a';
    static int _correctAnswers = 5;
    static int _correctclicks;

    private void OnEnable() 
    {
        GenerateBoard();
        UpdateDisplayLetters();
    }

    private static void GenerateBoard()
    {
        var clickables = FindObjectsOfType<PickTheSmallLetter>();
        int count = clickables.Length;

        List<char> letterList = new List<char>();

        for (int i = 0; i < _correctAnswers; i++)
          letterList.Add(_letter);
        
        for (int i = _correctAnswers; i < count; i++)
        {    
            var chosenLetter = ChooseInvalidRandomLetter();
            letterList.Add(chosenLetter);
        }
          letterList = letterList.OrderBy(t => UnityEngine.Random.Range(0, 10000)).ToList();

        for (int i = 0; i < count; i++)
        {
            clickables[i].SetLetter(letterList[i]);
        }

        FindObjectOfType<RemainingLetterCount>().SetRemaining(_correctAnswers - _correctclicks);

    }

    internal static void HandleCorrectLetterClick()
    {
        _correctclicks++;
        FindObjectOfType<RemainingLetterCount>().SetRemaining(_correctAnswers - _correctclicks);
        if (_correctclicks >= _correctAnswers)
        {
            _letter++;
            UpdateDisplayLetters();
            _correctclicks = 0;
            GenerateBoard();
        }
    }

    private static void UpdateDisplayLetters()
    {
        foreach (var displayletter in FindObjectsOfType<DisplayLetter>())
        {
            displayletter.SetLetter(_letter);
        }
    }

    private static char ChooseInvalidRandomLetter()
    {
        int a = UnityEngine.Random.Range(0,26);
              var randomLetter = (char) ('a' + a);
              while (randomLetter == _letter)
              {
                  a = UnityEngine.Random.Range(0,26);
                   randomLetter = (char) ('a' + a);
              }
              
            return randomLetter;
    }
}

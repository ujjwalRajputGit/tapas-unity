using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using TMPro;
using Tapas.Common;
using System;
using Tapas.Common.Constants;
using Random = UnityEngine.Random;

namespace Tapas.CountTheFigures
{
  public class GameController : MonoBehaviour
  {
    [SerializeField] TMP_Text CountText;
    [SerializeField] List<Image> countImages;
    [SerializeField] SpriteAtlas countImagesAtlas;
    [SerializeField] List<TMP_Text> OptionsTexts;
    [SerializeField] string figureName;
    List<int> numberList = new List<int>();
    public string correctAnswer;
    
    private void Start()
    {
      DisplayCountText();
      DisplayCountImages(figureName, Random.Range(0, 9));
    }

    private void DisplayCountImages(string imageName, int index)
    {
      for (int i = 0; i < countImages.Count; i++)
      {
        if (i <= index)
        {
          countImages[i].sprite = countImagesAtlas.GetSprite(imageName);
          countImages[i].SetNativeSize();
        }
        else
        {
          countImages[i].enabled = false;
        }
      }
      CountSimilarNumberGenerator(index);
      correctAnswer = index.ToString();
    }

    private void DisplayCountText()
    {
      int random = Random.Range(0, 78);
      figureName = Data.wordCollectionList[random];
      CountText.text = "Count The " + figureName + "s";
      if(random == 18 || random == 34 || random == 57 || random == 64)
      {
        CountText.text = "Count The " + figureName;
      }
    }
    private void DisplayOptionstext()
    {
      foreach (TMP_Text t in OptionsTexts)
      {
        int random = Random.Range(0, numberList.Count);
        t.text = numberList[random].ToString();
        numberList.RemoveAt(random);
      }
    }
    void CountSimilarNumberGenerator(int number)
    {
      numberList.Clear();

      numberList.Add(number + 1);
      numberList.Add(RandomNumberExcept(numberList));
      numberList.Add(RandomNumberExcept(numberList));
      numberList.Add(RandomNumberExcept(numberList));

      DisplayOptionstext();
    }

    int RandomNumberExcept(List<int> list)
    {
      int num = Random.Range(1, 10);
      if (list.Contains(num))
      {
        num = RandomNumberExcept(list);
      }
      return num;
    }

  }
}

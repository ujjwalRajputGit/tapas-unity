using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.U2D;
using UnityEngine.UI;

public class AbcMatchingController : MonoBehaviour
{
  [SerializeField]List<TMP_Text> letterTexts;
  [SerializeField]List<TMP_Text> alphabetTexts;
  [SerializeField]List<Image> wordImages;
  [SerializeField] SpriteAtlas wordImagesAtlas;
  List<string> letterList = new List<string>();
  List<string> alphabetList = new List<string>();
  List<string> wordCollectinList = new List<string>(new string[] { 
    "Apple", "Ant", "Axe",
    "Ball", "Boy", "Book",
    "Cat", "Clock", "Car",
    "Dog", "Doll", "Door",
    "Elephant", "Egg", "Eye",
    "Fox", "Fan", "Fish",
    "Grapes", "Goat", "Girl",
    "Hen", "Horse", "Hat",
    "Icecream", "Ink", "Island",
    "Joker", "Jug", "Jacket",
    "Kite", "Key", "King",
    "Lion", "Lotus", "Leg",
    "Mango", "Milk", "Monkey",
    "Nest", "Net", "Nose",
    "Orange", "Owl", "Onion",
    "Pen", "Parrot", "Panda",
    "Queen", "Question", "Quiet",
    "Rose", "Rabbit", "Ring",
    "Snake", "Sun", "Spoon",
    "Toys", "Table", "Tiger",
    "Umbrella", "Uniform", "Umpire",
    "Van", "Vegetables", "Volcano",
    "Watermelon", "Water", "Whale",
    "X-Mas Tree", "Xylophone", "X-Ray",
    "Yellow", "Yak", "Yoga",
    "Zebra", "Zero", "Zoo"
  });
  
  private void Start() {
    DisplayLettes();
    DisplayAlphabets();
    DisplayImages();
  }
  void DisplayLettes() { 
    letterList.Clear(); 
    while (letterList.Count < letterTexts.Count) {
      string letter = RandomLetterGenerator();
      if(!letterList.Contains(letter)) {
        letterTexts[letterList.Count].text = letter;
        letterList.Add(letter);
      }            
    }
  }

  void DisplayAlphabets() {
    LettersMatchingAlphabetGenerator();
    foreach (TMP_Text t in alphabetTexts) {
      int random = Random.Range(0, alphabetList.Count);
      t.text = alphabetList[random];
      alphabetList.RemoveAt(random);
    }
  }

  void DisplayImages() {

  }

  void LettersMatchingAlphabetGenerator() {
    alphabetList.Clear();
    foreach (string s in letterList) {
      int r1 = (StringToInt(s,0) - 65) * 3 ;
      int r2 = (3 + r1);
      int random = Random.Range(r1, r2);
      alphabetList.Add(wordCollectinList[random]);
    }
  }
  // GetComponent<TMP_Text>().text = randomLetter.ToString().ToUpper();

  int StringToInt(string s, int index) {
    int i = s[index];
    return i;
  }
    
  string RandomLetterGenerator() {
    int randomNum = Random.Range(0,26);
    char randomLetter = (char) ('A' + randomNum);
    return randomLetter.ToString();
  }

  private void Update() {
    if(Input.GetKeyDown(KeyCode.P)) {
      Debug.Log(StringToInt("A",0));
    }
        
  }
}

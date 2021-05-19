using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbcMatchingController : MonoBehaviour
{
  [SerializeField]List<TMP_Text> upperText;
  List<string> letterList = new List<string>();
  List<string> wordList = new List<string>(new string[] 
  { 
    "Apple", "Ant", "Axe",
    "Ball", "Boy", "Book",
    "Cat", "Clock", "Cake",
    "Dog", "Doll", "Door",
    "Elephant", "Eggs", "Ear",
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
    "Sky", "Sun", "Spoon",
    "Toys", "Table", "Tiger",
    "Umbrella", "Uniform", "Umpire",
    "Van", "Vegetable", "Volcano",
    "Watermelon", "Water", "Whale",
    "X-Mas Tree", "Xylophone", "X-Ray",
    "Yellow", "Yak", "Yoga",
    "Zebra", "Zero", "Zoo"
  });
  private void Start() {
    UpperTextDisplay();
  }
  void UpperTextDisplay() { 
    letterList.Clear(); 
    while (letterList.Count < upperText.Count) {
      string letter = RandomLetterGenerator();
      if(!letterList.Contains(letter)) {
        letterList.Add(letter); 
      }            
    } 
    for(int i = 0; i < upperText.Count; i++) {
      upperText[i].text = letterList[i].ToUpper();
    }   
  }
    //    GetComponent<TMP_Text>().text = randomLetter.ToString().ToUpper();
  string RandomLetterGenerator() {
    int randomNum = Random.Range(0,26);
    char randomLetter = (char) ('a' + randomNum);
    return randomLetter.ToString();
  }

  private void Update() {
    if(Input.GetKeyDown(KeyCode.P)) {
      Debug.Log((char) ('a' + 1));
    }
        
  }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BubbleBurst : MonoBehaviour
{
    public List<string> wordList = new List<string>();
    [SerializeField]List<TMP_Text> bubbleTexts;
     List<string> wordCollectionList = new List<string>(new string[] { 
    "Apple", "Ant", "Axe",
    "Ball", "Boy", "Book",
    "Cat", "Clock", "Car",
    "Dog", "Doll", "Door",
    "Elephant", "Egg", "Eye",
    "Fox", "Fan", "Fish",
    "Grapes", "Goat", "Girl",
    "Hen", "Horse", "Hat",
    "Ice cream", "Ink", "Island",
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
   
   private void Start() 
   {
      DisplayRandomAlphabet();
      DisplayWords();
   }

    void DisplayRandomAlphabet()
    {
       int a = Random.Range(0,26);
        char _randomAlphabet = (char) ('A' + a);
        //GetComponent<TMP_Text>().text = _randomAlphabet.ToString();
    }

    void DisplayWords() {
    AlphabetSimilarWordsGenerator();
    foreach (TMP_Text t in bubbleTexts) {
      int random = Random.Range(0, wordList.Count);
      string wordName = wordList[random];
      t.text = wordName;
      wordList.RemoveAt(random);
    }
  }
  void AlphabetSimilarWordsGenerator() {
    wordList.Clear();
      int r1 = (StringToInt("A", 0) - 65) * 3 ;
      int r2 = (3 + r1);
      wordList.Add(wordCollectionList[r1]);
      wordList.Add(wordCollectionList[r1 + 1]);
      wordList.Add(wordCollectionList[r1 + 2]);
  }

    private int StringToInt(string s, int index)
    {
        int i = s[index];
        return i;
    }
}

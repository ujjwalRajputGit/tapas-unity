using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Tapas.BubbleBurst
{
	public class BubbleBurst : MonoBehaviour
	{
		[SerializeField] List<TMP_Text> bubbleTexts;
		List<string> wordList = new List<string>();
		List<string> wordCollectionList = new List<string>(new[] {
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

		private void Start() {
			DisplayWords();
		}

		void DisplayWords() {
			AlphabetSimilarWordsGenerator();
			foreach (TMP_Text t in bubbleTexts) {
				int random = Random.Range(0, wordList.Count);
				t.text = wordList[random];
				wordList.RemoveAt(random);
			}
		}

		void AlphabetSimilarWordsGenerator() {
			wordList.Clear();
			int r1 = (StringToInt("A", 0) - 65) * 3;
			wordList.Add(wordCollectionList[r1]);
			wordList.Add(wordCollectionList[r1 + 1]);
			wordList.Add(wordCollectionList[r1 + 2]);
		}

		private int StringToInt(string s, int index) {
			int i = s[index];
			return i;
		}
	}
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Tapas.Common;
using UnityEngine.SceneManagement;

namespace Tapas.BubbleBurst
{
	public class GameController : MonoBehaviour
	{
		[SerializeField] List<TMP_Text> bubbleTexts;
		[SerializeField] TMP_Text alphabetText;
		public string randomAlphabet;
		List<string> wordList = new List<string>();

		private void Start() {
			DisplayAlphabet();
			DisplayWords(); 
		}

    private void DisplayAlphabet()
    {
      
			randomAlphabet = RandomAlphabetGenerator();
			alphabetText.text = randomAlphabet;
		}

		string RandomAlphabetGenerator() {
			int randomNum = Random.Range(0, 26);
			char randomLetter = (char) ('A' + randomNum);
			return randomLetter.ToString();
		}

    void DisplayWords() {
			AlphabetSimilarWordsGenerator();
			foreach (TMP_Text t in bubbleTexts) {
				int random = Random.Range(0, wordList.Count);
				t.text = wordList[random];
				wordList.RemoveAt(random);
			 }
		}
    int RandomNumberExcept(int value) 
    {
       int num = Random.Range(0,78);
      if(num == value || num == value + 1 || num == value+ 2) {
      num = RandomNumberExcept(value);
    }
      return num;
   }
		void AlphabetSimilarWordsGenerator() {
			wordList.Clear();
			int r1 = (StringToInt(randomAlphabet, 0) - 65) * 3;
			wordList.Add(Data.wordCollectionList[r1]);
			wordList.Add(Data.wordCollectionList[r1 + 1]);
			wordList.Add(Data.wordCollectionList[r1 + 2]);
			wordList.Add(Data.wordCollectionList[RandomNumberExcept(r1)]);
			wordList.Add(Data.wordCollectionList[RandomNumberExcept(r1)]);
			}

		private int StringToInt(string s, int index)
		{
			int i = s[index];
			return i;
		}
		public void OnBackButtonClick()
        {
            SceneManager.LoadScene ("AlphabetsGamesScreen");
        }		
	}
}

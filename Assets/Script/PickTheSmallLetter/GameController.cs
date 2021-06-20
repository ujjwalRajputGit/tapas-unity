using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tapas.PickTheSmallLetter
{
	public class GameController : MonoBehaviour
	{
		public static char letter = 'a';
		static int correctAnswers = 5;
		static int correctClicks;

		void OnEnable() {
			GenerateBoard();
			UpdateDisplayLetters();
		}

		static void GenerateBoard() {
			var clickable = FindObjectsOfType<PickTheSmallLetter>();
			int count = clickable.Length;
			List<char> letterList = new List<char>();

			for (int i = 0; i < correctAnswers; i++)
				letterList.Add(letter);

			for (int i = correctAnswers; i < count; i++) {
				var chosenLetter = ChooseInvalidRandomLetter();
				letterList.Add(chosenLetter);
			}
			
			letterList = letterList.OrderBy(t => Random.Range(0, 10000)).ToList();

			for (int i = 0; i < count; i++) {
				clickable[i].SetLetter(letterList[i]);
			}

			FindObjectOfType<RemainingLetterCount>().SetRemaining(correctAnswers - correctClicks);
		}

		internal static void HandleCorrectLetterClick() {
			correctClicks++;
			FindObjectOfType<RemainingLetterCount>().SetRemaining(correctAnswers - correctClicks);
			if (correctClicks >= correctAnswers) {
				letter++;
				UpdateDisplayLetters();
				correctClicks = 0;
				GenerateBoard();
			}
		}

		static void UpdateDisplayLetters() {
			foreach (var displayLetter in FindObjectsOfType<DisplayLetter>()) {
				displayLetter.SetLetter(letter);
			}
		}

		static char ChooseInvalidRandomLetter() {
			int a = Random.Range(0, 26);
			var randomLetter = (char) ('a' + a);
			while (randomLetter == letter) {
				a = Random.Range(0, 26);
				randomLetter = (char) ('a' + a);
			}

			return randomLetter;
		}
	}
}

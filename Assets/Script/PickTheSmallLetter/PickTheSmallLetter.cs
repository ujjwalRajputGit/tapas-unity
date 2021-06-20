using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Tapas.PickTheSmallLetter
{
	public class PickTheSmallLetter : MonoBehaviour, IPointerClickHandler, IPointerUpHandler
	{
		char randomLetter;

		public void OnPointerClick(PointerEventData eventData) {
			if (randomLetter == GameController.letter) {
				GetComponent<TMP_Text>().color = Color.green;
				enabled = false;
				GameController.HandleCorrectLetterClick();
			}
			else {
				GetComponent<TMP_Text>().color = Color.red;
			}
		}

		public void OnPointerUp(PointerEventData eventData) {
			if (randomLetter != GameController.letter) {
				GetComponent<TMP_Text>().color = Color.white;
			}
		}


//    private void OnEnable() 
//    {
//        int a = Random.Range(0,26);
//        _randomLetter = (char) ('a' + a);
//        GetComponent<TMP_Text>().text = _randomLetter.ToString();
//    }

		public void SetLetter(char letter) {
			enabled = true;
			GetComponent<TMP_Text>().color = Color.white;
			randomLetter = letter;
			GetComponent<TMP_Text>().text = randomLetter.ToString();
		}
	}
}

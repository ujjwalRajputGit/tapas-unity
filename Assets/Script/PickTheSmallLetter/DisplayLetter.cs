using TMPro;
using UnityEngine;

namespace Tapas.PickTheSmallLetter
{
	public class DisplayLetter : MonoBehaviour
	{
		public void SetLetter(char letter) {
			GetComponent<TMP_Text>().text = letter.ToString().ToUpper();
		}
	}
}

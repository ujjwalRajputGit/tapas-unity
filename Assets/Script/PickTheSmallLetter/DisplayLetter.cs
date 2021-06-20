using TMPro;
using UnityEngine;

namespace PickTheSmallLetter
{
	public class DisplayLetter : MonoBehaviour
	{
		internal void SetLetter(char letter) {
			GetComponent<TMP_Text>().text = letter.ToString().ToUpper();
		}
	}
}

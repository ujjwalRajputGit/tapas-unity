using TMPro;
using UnityEngine;

namespace PickTheSmallLetter
{
	public class RemainingLetterCount : MonoBehaviour
	{
		internal void SetRemaining(int remaining) {
			GetComponent<TMP_Text>().text = "x" + remaining;
		}
	}
}

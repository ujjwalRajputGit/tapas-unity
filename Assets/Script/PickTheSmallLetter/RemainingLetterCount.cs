using TMPro;
using UnityEngine;

namespace Tapas.PickTheSmallLetter
{
	public class RemainingLetterCount : MonoBehaviour
	{
		internal void SetRemaining(int remaining) {
			GetComponent<TMP_Text>().text = "x" + remaining;
		}
	}
}

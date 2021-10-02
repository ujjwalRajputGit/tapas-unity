using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Tapas.AbcMatching
{
	public class LineMatch : MonoBehaviour
	{
		List<string> stringList = new List<string>();
		public static UnityAction<List<string>> matchAnswer;
		void OnTriggerEnter2D(Collider2D other) {
			var tmpText = other.GetComponent<TMP_Text>().text;
			stringList.Add(tmpText);
			if (stringList.Count >= 2) {
				FireEvent(stringList);
				stringList.Clear();
			}
		}

		void FireEvent(List<string> value) {
			matchAnswer?.Invoke(value);
		}

	}
}

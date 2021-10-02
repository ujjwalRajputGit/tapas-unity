using System.Collections;
using Tapas.Interface;
using UnityEngine;

namespace Tapas.Common
{
	public class ResultScreen : MonoBehaviour
	{
		[SerializeField] GameObject rightAnswerObject;
		[SerializeField] GameObject wrongAnswerObject;

		public void StartResultScreen(Result operation, IGameController gameController) {
			switch (operation) {
				case Result.RIGHTANSWER:
					gameObject.SetActive(true);
					rightAnswerObject.SetActive(true);
					break;

				case Result.WRONGANSWER:
					gameObject.SetActive(true);
					wrongAnswerObject.SetActive(true);
					break;

				default:
					Debug.LogError("wrong operation value");
					break;
			}

			StartCoroutine(PlayAgain(gameController));
		}

		IEnumerator PlayAgain(IGameController gameController) {
			yield return new WaitForSeconds(2f);
			gameObject.SetActive(false);
			rightAnswerObject.SetActive(false);
			wrongAnswerObject.SetActive(false);
			gameController.PlayAgain();
		}
	}

	public enum Result
	{
		RIGHTANSWER,
		WRONGANSWER,
	}

}

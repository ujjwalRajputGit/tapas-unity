using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Tapas.BubbleBurst
{
	public class Burst : MonoBehaviour 
	{
    GameController gameController;
    public void OnButtonClick(TMP_Text bubbleTMP) {
        if (bubbleTMP.text[0] == gameController.randomAlphabet[0]) {
            bubbleTMP.gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
    private void Awake() {
        gameController = GetComponent<GameController>();
    }
	}
}

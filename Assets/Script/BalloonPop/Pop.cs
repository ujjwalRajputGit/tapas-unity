using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Tapas.BalloonPop
{
    public class Pop : MonoBehaviour
    {
    GameController gameController;
    public void OnButtonClick(TMP_Text balloonTMP) {
        if (balloonTMP.text[0] == gameController.randomNumber[0]) {
            balloonTMP.gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
    private void Awake() {
        gameController = GetComponent<GameController>();
    }
    }
}

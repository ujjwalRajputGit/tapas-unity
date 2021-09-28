using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Tapas.CountTheFigures
{
    public class CorrectAnswer : MonoBehaviour
    {
        GameController gameController;
    public void OnButtonClick(TMP_Text optionTMP) {
        if (optionTMP.text[0] == gameController.correctAnswer[0]+1) {
            optionTMP.gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
    private void Awake() {
        gameController = GetComponent<GameController>();
    }
    }
}

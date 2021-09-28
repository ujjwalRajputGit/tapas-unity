using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tapas
{
    public class MathematicsGamesScreen : MonoBehaviour
    {
        public void OnCountTheFiguresClick()
        {
            SceneManager.LoadScene ("CountTheFigures");
        }		
         public void OnBalloonPopClick()
        {
            SceneManager.LoadScene ("BalloonPop");
        }		
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene ("MainMenu");
        }		
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tapas.FunActivitiesGameScreen
{
    public class FunActivitiesGameScreen : MonoBehaviour
    {
         public void OnPuzzleClick()
        {
            SceneManager.LoadScene ("Puzzle");
        }		
         public void OnFixTheFacesClick()
        {
            SceneManager.LoadScene ("FixTheFaces");
        }		
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene ("MainMenu");
        }		   
    }
}

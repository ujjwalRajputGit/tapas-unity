using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tapas.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
         public void OnAlphabetsGameClick()
        {
            SceneManager.LoadScene ("AlphabetsGamesScreen");
        }		
         public void OnMathematicsGameClick()
        {
            SceneManager.LoadScene ("MathematicsGamesScreen");
        }		
        public void OnFunActivitiesGameClick()
        {
            SceneManager.LoadScene ("FunActivitiesGamesScreen");
        }		   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tapas.AlphabetsGamesScreen
{
    public class AlphabetsGamesScreen : MonoBehaviour
    {
        public void OnMatchingAtoAppleClick()
        {
            SceneManager.LoadScene ("AbcMatching");
        }		
         public void OnBubbleBurstClick()
        {
            SceneManager.LoadScene ("BubbleBurst");
        }		
        public void OnPickTheSmallLetterClick()
        {
            SceneManager.LoadScene ("PickTheSmallLetter");
        }		
         public void OnBackButtonClick()
        {
            SceneManager.LoadScene ("MainMenu");
        }		
    }
}

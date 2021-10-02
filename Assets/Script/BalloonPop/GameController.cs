using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Tapas.BalloonPop
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] TMP_Text NumberText;
        [SerializeField] List<TMP_Text> BalloonTexts;
        List<string> numberList = new List<string>();
        public string randomNumber;
        void Start()
        {
            DisplayNumber();
            DisplayBalloonText();
        }
        void DisplayNumber(){
            randomNumber = randomNumberGenerator().ToString();
            NumberText.text = "Touch The Number " + randomNumber; 
        }
        int randomNumberGenerator(){
            int randomNum = Random.Range(0, 10);
            return randomNum;
        }
        void DisplayBalloonText(){
            	NumberSimilarNumberGenerator();
			foreach (TMP_Text t in BalloonTexts) {
				int random = Random.Range(0, numberList.Count);
				t.text = numberList[random];
				numberList.RemoveAt(random);
            }
        }
        void NumberSimilarNumberGenerator(){
            numberList.Clear();
            numberList.Add(randomNumber);
            numberList.Add(Random.Range(0,10).ToString());
            numberList.Add(Random.Range(0,10).ToString());
            numberList.Add(Random.Range(0,10).ToString());
        }
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene ("MathematicsGamesScreen");
        }		
    }
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbcMatchingController : MonoBehaviour
{
    [SerializeField]List<TMP_Text> upperText;
    List<string> letterList = new List<string>();

    private void Start() {
        UpperTextDisplay();
    }
    void UpperTextDisplay() { 
        letterList.Clear(); 
        while (letterList.Count < upperText.Count) {
           string letter = RandomLetterGenerator();
            if(!letterList.Contains(letter)) 
                letterList.Add(letter);             
        } 
        for(int i = 0; i < upperText.Count; i++) {
            upperText[i].text = letterList[i].ToUpper();
        }   
    }
    //    GetComponent<TMP_Text>().text = randomLetter.ToString().ToUpper();
    string RandomLetterGenerator() {
        int randomNum = Random.Range(0,26);
        char randomLetter = (char) ('a' + randomNum);
        return randomLetter.ToString();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.P)) {
            foreach (string s  in letterList)
            {
                Debug.Log(s);
            }
        }
    }
}

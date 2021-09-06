using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tapas.Puzzle
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Transform[] puzzleImages;
        [SerializeField] private GameObject winText;
        public static bool youWin;
        void Start()
        {
            winText.SetActive(false);
            youWin = false;
        }
        void Update()
        {
            if(puzzleImages[0].rotation.z == 0 &&
               puzzleImages[1].rotation.z == 0 &&
               puzzleImages[2].rotation.z == 0 &&
               puzzleImages[3].rotation.z == 0 &&
               puzzleImages[4].rotation.z == 0 &&
               puzzleImages[5].rotation.z == 0 &&
               puzzleImages[6].rotation.z == 0 &&
               puzzleImages[7].rotation.z == 0 &&
               puzzleImages[8].rotation.z == 0 &&
               puzzleImages[9].rotation.z == 0 &&
               puzzleImages[10].rotation.z == 0 &&
               puzzleImages[11].rotation.z == 0 &&
               puzzleImages[12].rotation.z == 0 &&
               puzzleImages[13].rotation.z == 0 &&
               puzzleImages[14].rotation.z == 0 &&
               puzzleImages[15].rotation.z == 0)
               {
                   youWin = true;
                   winText.SetActive(true);
               }
        }
    }
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using Tapas.Common;
using UnityEngine.SceneManagement;

namespace Tapas.AbcMatching
{
	public class GameController : MonoBehaviour
	{
		[SerializeField] List<TMP_Text> alphabetTexts;
		[SerializeField] List<TMP_Text> wordTexts;
		[SerializeField] List<Image> wordImages;
		[SerializeField] SpriteAtlas wordImagesAtlas;
		[SerializeField] GameObject linePrefab;
		List<Vector2> fingerPositions = new List<Vector2>();
		GameObject currentLine;
		LineRenderer lineRenderer;
		EdgeCollider2D edgeCollider2D;
		Camera mainCamera;
		List<string> alphabetList = new List<string>();
		List<string> wordList = new List<string>();

		void Start() {
			DisplayAlphabets();
			DisplayWords();
		}

		void Awake() {
			mainCamera = Camera.main;
		}

		void DisplayAlphabets() {
			alphabetList.Clear();
			while (alphabetList.Count < alphabetTexts.Count) {
				string letter = RandomAlphabetGenerator();
				if (!alphabetList.Contains(letter)) {
					alphabetTexts[alphabetList.Count].text = letter;
					alphabetList.Add(letter);
				}
			}
		}

		void DisplayWords() {
			AlphabetMatchingWordGenerator();
			foreach (TMP_Text t in wordTexts) {
				int random = Random.Range(0, wordList.Count);
				string wordName = wordList[random];
				t.text = wordName;
				DisplayImages(wordName, (3 - wordList.Count));
				wordList.RemoveAt(random);
			}
		}

		void DisplayImages(string imageName, int index) {
			wordImages[index].sprite = wordImagesAtlas.GetSprite(imageName);
			wordImages[index].SetNativeSize();
		}

		void AlphabetMatchingWordGenerator() {
			wordList.Clear();
			foreach (string s in alphabetList) {
				int r1 = (StringToInt(s, 0) - 65) * 3;
				int r2 = (3 + r1);
				int random = Random.Range(r1, r2);
				wordList.Add(Data.wordCollectionList[random]);
			}
		}
		// GetComponent<TMP_Text>().text = randomLetter.ToString().ToUpper();

		int StringToInt(string s, int index) {
			int i = s[index];
			return i;
		}

		string RandomAlphabetGenerator() {
			int randomNum = Random.Range(0, 26);
			char randomLetter = (char) ('A' + randomNum);
			return randomLetter.ToString();
		}

		void CreateLine(Vector2 firstFingerPos) {
			currentLine = Instantiate(linePrefab, Vector3.zero, linePrefab.transform.rotation);
			lineRenderer = currentLine.GetComponent<LineRenderer>();
			edgeCollider2D = currentLine.GetComponent<EdgeCollider2D>();
			fingerPositions.Clear();
			fingerPositions.Add(mainCamera.ScreenToWorldPoint(firstFingerPos));
			fingerPositions.Add(mainCamera.ScreenToWorldPoint(firstFingerPos));
			lineRenderer.SetPosition(0, fingerPositions[0]);
			lineRenderer.SetPosition(1, fingerPositions[1]);
			edgeCollider2D.points = fingerPositions.ToArray();
		}

		void UpdateLine(Vector2 newFingerPos) {
			fingerPositions.Add(newFingerPos);
			lineRenderer.positionCount++;
			lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
			edgeCollider2D.points = fingerPositions.ToArray();
		}

		void DrawLine() {
			if (Input.GetMouseButtonDown(0)) {
				CreateLine(Input.mousePosition);
			}
			if (Input.GetMouseButton(0)) {
				Vector2 tempFingerPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
				if (Vector2.Distance(tempFingerPos, fingerPositions[fingerPositions.Count - 1]) > 0.1f) {
					UpdateLine(tempFingerPos);
				}
			}
		}

		private void Update() {
			DrawLine();
		}
		public void OnBackButtonClick()
        {
            SceneManager.LoadScene ("AlphabetsGamesScreen");
        }		
	}
}

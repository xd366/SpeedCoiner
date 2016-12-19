using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public CarController theCar;
	private Vector3 carStartPoint;

	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;
	public WinMenu theWinMenu;

    public GameObject[] possibleItemsToReset;

	void Start () {
		
		carStartPoint = theCar.transform.position;
		theScoreManager = FindObjectOfType<ScoreManager> ();
        possibleItemsToReset = FindObjectsOfType<GameObject>();
	}

	void Update () {

	}

	public void RestartGame()
	{

		theScoreManager.scoreIncreasing = false;
		theCar.gameObject.SetActive (false);
		theDeathScreen.gameObject.SetActive (true);
        for (int i=0; i<possibleItemsToReset.Length-1; i++) {
            if (possibleItemsToReset[i].CompareTag("Coins") == true) {
                possibleItemsToReset[i].SetActive(true);
            } else if (possibleItemsToReset[i].CompareTag("Diamonds") == true) {
                possibleItemsToReset[i].SetActive(true);
            }
        }

	}

	public void Reset()
	{
		theCar.transform.position = carStartPoint;
		theCar.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
		theDeathScreen.gameObject.SetActive (false);
		theWinMenu.gameObject.SetActive (false);
        /*
		*here we need something that resets the coins
		*so basically something that finds tags "Coins" & "diamonds"
		*and set them as active
		*/

        for (int i = 0; i < possibleItemsToReset.Length - 1; i++) {
            if (possibleItemsToReset[i].CompareTag("Coins") == true) {
                possibleItemsToReset[i].SetActive(true);
            } else if (possibleItemsToReset[i].CompareTag("Diamonds") == true) {
                possibleItemsToReset[i].SetActive(true);
            }
        }
    }
		

	public void FinishGame()
	{
		
		theScoreManager.scoreIncreasing = false;
		theCar.gameObject.SetActive (false);
		theWinMenu.gameObject.SetActive (true);
	}


		

}

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public CarController theCar;
	private Vector3 carStartPoint;

	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;

	void Start () {
		
		carStartPoint = theCar.transform.position;
		theScoreManager = FindObjectOfType<ScoreManager> ();

	}

	void Update () {

	}

	public void RestartGame()
	{

		theScoreManager.scoreIncreasing = false;
		theCar.gameObject.SetActive (false);
		theDeathScreen.gameObject.SetActive (true);

	}

	public void Reset()
	{
		theCar.transform.position = carStartPoint;
		theCar.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
		theDeathScreen.gameObject.SetActive (false);
	}
		

	public void FinishGame()
	{
		/*
		theScoreManager.scoreIncreasing = false;
		theCar.gameObject.SetActive (false);
		theWinScreen.gameObject.SetActive (true);
*/
	}


		

}

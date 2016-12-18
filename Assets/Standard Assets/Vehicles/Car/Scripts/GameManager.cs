using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public CarController theCar;
	private Vector3 carStartPoint;



	void Start () {
		
		carStartPoint = theCar.transform.position;


	}

	void Update () {

	}

	public void RestartGame()
	{
		//theScoreManager.scoreIncreasing = false;

		//theCar.gameObject.SetActive (false);

		StartCoroutine ("RestartGameCo");

//		theDeathScreen.gameObject.SetActive (true);

	}

	public IEnumerator RestartGameCo()
	{
		theCar.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		theCar.transform.position = carStartPoint;
		theCar.gameObject.SetActive (true);

		//theScoreManager.scoreIncreasing = false;






		//theScoreManager.scoreCount = 0;
		//theScoreManager.scoreIncreasing = true;
	}


	public void FinishGame()
	{
		/*
		theScoreManager.scoreIncreasing = false;
		theCar.gameObject.SetActive (false);
		theWinScreen.gameObject.SetActive (true);
*/
	}

	public void Reset()
	{
		/*
		 * theDeathScreen.gameObject.SetActive (false);
		theWinScreen.gameObject.SetActive (false);

		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for(int i = 0; i < platformList.Length; i++)
		{
			platformList[i].gameObject.SetActive(false);
		}

		theCar.transform.position = playerStartPoint;
		theCar.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
*/
	}
		

}

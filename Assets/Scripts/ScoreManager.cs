using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

	//currently this needs fixing, i just copied the score system
	//that i used for my 2d game
	//i will fix in a upcoming update


	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing;

	void Start () {
		if (PlayerPrefs.HasKey ("HighScore")) 
		{
			hiScoreCount = PlayerPrefs.GetFloat ("HighScore");
		}
	}

	void Update () {
		if (scoreIncreasing) 
		{
			/*
I removed the following line because it was from my 2D Game
it makes the score counter go up by one each second
			*/

			//scoreCount = scoreCount += pointsPerSecond * Time.deltaTime;
		}

		if (scoreCount > hiScoreCount)
		{
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("HighScore", hiScoreCount);
		}


		scoreText.text = "Score: " + Mathf.Round(scoreCount);
		hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);
	}

	public void AddScore(int pointsToAdd)
	{
		scoreCount += pointsToAdd;
	}

}

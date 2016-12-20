using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public float startingTime;
	public float theOriginalStartTime;
	private Text theText;
	public bool timeDecreasing;

	// Use this for initialization
	void Start () {

		theText = GetComponent<Text> ();
		theOriginalStartTime = startingTime;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timeDecreasing) 
		{
			startingTime -= Time.deltaTime;
		}
		theText.text = "" + Mathf.Round(startingTime);

		if (startingTime <= 0) 
		{
			FindObjectOfType<GameManager> ().RestartGame ();
			//startingTime = startingTime;
			timeDecreasing = false;
		}
	}
	public void AddTime(int timetoAdd)
	{
		startingTime += timetoAdd;
	}
}

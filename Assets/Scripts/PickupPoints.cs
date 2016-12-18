using UnityEngine;
using System.Collections;

public class PickupPoints : MonoBehaviour {

	public int scoreToGive;

	private ScoreManager theScoreManager;

	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "ColliderBottom")
		{
			theScoreManager.AddScore (scoreToGive);
			gameObject.SetActive (false);
		}

	}
}

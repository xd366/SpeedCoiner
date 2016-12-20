using UnityEngine;
using System.Collections;

public class TimePoints : MonoBehaviour {

	public int timeToGive;

	private TimeManager theTimeManager;

	// Use this for initialization
	void Start () {
		theTimeManager = FindObjectOfType<TimeManager> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "ColliderBottom")
		{
			theTimeManager.AddTime (timeToGive);
			gameObject.SetActive (false);
		}

	}
}

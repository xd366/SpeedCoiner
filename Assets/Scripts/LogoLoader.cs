using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LogoLoader : MonoBehaviour {


	public string backtoMenu;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Countdown");
	}

	private IEnumerator Countdown()
	{
		yield return new WaitForSeconds (6);

		{
			SceneManager.LoadScene (backtoMenu);

		}

	}
}

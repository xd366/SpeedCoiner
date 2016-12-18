using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;
	public string howToPlay;
	public string playCredits;

	public void PlayGame()
	{
		SceneManager.LoadScene (playGameLevel);

	}

	public void HowToPlay()
	{
		SceneManager.LoadScene (howToPlay);

	}

	public void Credits()
	{
		SceneManager.LoadScene (playCredits);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

}

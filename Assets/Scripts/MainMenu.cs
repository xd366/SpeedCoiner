using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;
	public string howToPlay;
	public string playCredits;
	public string backtoMenu;

	public void PlayGame()
	{
		SceneManager.LoadScene (playGameLevel);

	}

	public void HowToPlay()
	{
		SceneManager.LoadScene (howToPlay);

	}
	public void Menus()
	{
		SceneManager.LoadScene (backtoMenu);

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

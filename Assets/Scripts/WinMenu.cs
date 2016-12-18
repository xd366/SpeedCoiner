using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour {


	public string mainMenuLevel;

	public void RestartGame()
	{
		FindObjectOfType<GameManager>().Reset();
	}
		
	public void QuitToMain ()
	{
		SceneManager.LoadScene (mainMenuLevel);
	}
		

}

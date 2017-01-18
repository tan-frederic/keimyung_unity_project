using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private bool _onPause = false;
	private bool _game = true;
	[SerializeField]
	private GameObject _PauseGameView;
	[SerializeField]
	private GameObject _GameOverView;
	[SerializeField]
	private GameObject _EndLevelView;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape) && _game)
		{
			if (!_onPause) 
				PauseGame ();
			else 
				ResumeGame();
		}
	}

	public void ResumeGame()
	{
		_onPause = false;
		Time.timeScale = 1;
		_PauseGameView.SetActive (false);
	}

	public void PauseGame()
	{
		_onPause = true;
		Time.timeScale = 0;
		_PauseGameView.SetActive (true);
	}

	public void GameOver()
	{
		_game = false;
		Time.timeScale = 0;
		_GameOverView.SetActive (true);
	}

	public void EndLevel()
	{
		_game = false;
		Time.timeScale = 0;
		_EndLevelView.SetActive (true);
	}

	public void Retry()
	{
		Time.timeScale = 1;
		Application.LoadLevel(Application.loadedLevelName);
	}

	public void ReturnMainMenu()
	{
		Time.timeScale = 1;
		Application.LoadLevel("StartScreen");
	}

	public void ReturnSelectLevel()
	{
		Time.timeScale = 1;
		Application.LoadLevel("LevelSelection");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}

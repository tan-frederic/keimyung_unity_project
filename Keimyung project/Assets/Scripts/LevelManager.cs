using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public int typelevel = 0;

	public void LoadLevel(string levelName)
	{
		Time.timeScale = 1;
		Application.LoadLevel(levelName);
	}

    void Start()
    {
        MusicManager music = MusicManager._instance;
        if (music)
        {
            music.PlayMusic(typelevel);
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(name);
	}
	
	public void QuitRequest ()
    {
		Application.Quit();
	}

    public void LoadNextLevel()
    {
        Brick.breakableCount = 0;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
    public void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}

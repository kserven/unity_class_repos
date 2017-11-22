using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
	}
	
	public void QuitRequest ()
    {
		Application.Quit();
	}

    public void LoadNextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

}

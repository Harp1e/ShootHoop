using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeToNextLevel = 0.0f;

	// Use this for initialization
	void Start () {
		// Load scene
	}
	
	// Update is called once per frame
	void Update () {
		if(timeToNextLevel > 0){
			timeToNextLevel -= Time.deltaTime;
			if (timeToNextLevel <= 0) {
				LoadNextScene();
			}
		}
	}

	public void LoadNextScene() {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex + 1);
	}

	public void LoadPreviousScene() {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex - 1);
	}
}

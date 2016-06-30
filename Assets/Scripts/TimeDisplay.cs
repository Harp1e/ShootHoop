using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	private Text timeText;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timeText = GetComponent<Text>();
		levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		timeText.text = "Time remaining: " + levelManager.timeToNextLevel.ToString();
	}
}
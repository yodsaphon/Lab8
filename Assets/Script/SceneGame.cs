using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneGame : MonoBehaviour {
	
	public Text Score;
	int score;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void scorepush(){
		

		score++;
		Score.text = "Score : " + score;
	}
}

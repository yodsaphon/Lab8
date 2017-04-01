using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBall : MonoBehaviour {

	public Text Score;
	int score;
	int score2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Target") {
			Destroy (collision.gameObject);
			Destroy (gameObject);
			scorepush ();

		}
	}

	public void scorepush(){
		score2 = score2 + score++;
		Score.text = "Score : " + score;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TT : MonoBehaviour {
	public Text t;
	public float n;


	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		n -= Time.deltaTime;
		t.text = Mathf.Round (n).ToString();

		if (n < 0) {
			t.text = "0";
		}


	}
}

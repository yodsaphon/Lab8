using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovebyDonk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveByDonk (){
		transform.position = new Vector3 (transform.position.x+1, transform.position.y, transform.position.z);

	}

	public void Left(){
		transform.position = new Vector3 (transform.position.x-1,transform.position.y, transform.position.z);
	}

}

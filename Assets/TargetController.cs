using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

	public GameObject dieEffectPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroy(){
		GameObject dieEffect = Instantiate (dieEffectPrefab);
		dieEffect.transform.position = this.gameObject.transform.position;

	}
}

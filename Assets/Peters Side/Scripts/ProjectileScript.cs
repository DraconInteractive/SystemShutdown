﻿using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.tag == "Enemy"){
			Destroy(this.gameObject);
		}
	}

}

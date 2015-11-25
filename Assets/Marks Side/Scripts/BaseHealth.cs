using UnityEngine;
using System.Collections;

public class BaseHealth : MonoBehaviour {
	public int baseHealth;


	void Start () {
		baseHealth = 100;
	}

	void Update () {
		Debug.Log ("Base = " + baseHealth);
	}
}

using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour {
	public GameObject selectedTower;

	void Start () {
	
	}

	void Update () {
	
	}

	public void SellTower(){
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth> ().nTowers -= 1;
		Destroy (selectedTower);
	}
}

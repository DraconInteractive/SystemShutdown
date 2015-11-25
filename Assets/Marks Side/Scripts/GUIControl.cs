using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour {
	public GameObject selectedTower;

	void Start () {
	
	}

	void Update () {
	
	}

	public void UnpowerTower(){
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth>().RemoveFromList (this.gameObject);
		Destroy (selectedTower);
	}
}

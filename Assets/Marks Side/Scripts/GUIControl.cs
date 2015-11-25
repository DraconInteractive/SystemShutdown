using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour {
	public GameObject selectedTower;

	void Start () {
	
	}

	void Update () {
	
	}

	public void UnpowerTower(){
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth>().RemoveFromList (selectedTower);
		Destroy (selectedTower);
	}

	public void EMPButton(){
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth> ().power -= 5;
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		foreach (GameObject i in enemies) {
			i.GetComponent <EnemyBasic>().ChangeEnemyNumber();
		}
	}
}

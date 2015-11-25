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
			if(i.GetComponent<OnType1>()){
				Camera.main.GetComponent <EnemySpawning> ().nE1 -= 1;
			} else if (i.GetComponent<OnType2>()){
				Camera.main.GetComponent <EnemySpawning> ().nE2 -= 1;
			} else if (i.GetComponent<OnType3>()){
				Camera.main.GetComponent <EnemySpawning> ().nE3 -= 1;
			}
			Destroy (i);
		}
	}
}

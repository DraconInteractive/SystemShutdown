using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour {
	public GameObject selectedTower;

	void Start () {
	
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)){
			SelectTower();
		}
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

	public void SelectTower (){
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
			GameObject hitObj = hit.collider.gameObject;

			if (hitObj.tag == "Turret"){
				hitObj.GetComponent<TowerSelectScript>().SelectTower();
				selectedTower = hitObj;
				Debug.Log ("Hit Tower");
			} else {
				Debug.Log (hitObj.name);
			}

			// Do something with the object that was hit by the raycast.
		} else {
			Debug.Log ("Nothing Hit");
		}
	}
}

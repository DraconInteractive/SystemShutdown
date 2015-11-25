using UnityEngine;
using System.Collections;

public class TowerSelectScript : MonoBehaviour {
	public bool isSelected;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		SelectionAction();
	}

	public void SelectTower(){

		if (isSelected){
			isSelected = false;
		} else {
			GameObject[] towers = GameObject.FindGameObjectsWithTag("Turret");
			foreach (GameObject i in towers){
				i.GetComponent<TowerSelectScript>().isSelected = false;
			}

			isSelected = true;
		}
	}

	public void SelectionAction(){
		if (isSelected){
			Component halo = GetComponent("Halo"); 
			halo.GetType().GetProperty("enabled").SetValue(halo, true, null); 
		} else {
			Component halo = GetComponent("Halo"); 
			halo.GetType().GetProperty("enabled").SetValue(halo, false, null); 
		}
	}
}

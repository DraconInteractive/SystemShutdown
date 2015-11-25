using UnityEngine;
using System.Collections;

public class GateStuff : MonoBehaviour {
	public NavMeshObstacle gate;
	public bool mouseOver, off;

	void Start () {
		gate = GetComponent<NavMeshObstacle>();
		GetComponent<NavMeshObstacle>().carving = true;
	}

	void OnMouseEnter(){
		mouseOver = true;
	}
	void OnMouseExit(){
		mouseOver = false;
	}

	void OnMouseDown(){
		if (mouseOver == true && off == false) {
			off = true;
			GetComponent<NavMeshObstacle>().carving = false;
			GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth>().RemoveFromList (this.gameObject);
		}else{
			off = false;
			GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth>().AddToList (this.gameObject);
			GetComponent<NavMeshObstacle>().carving = true;
		}
	}
}

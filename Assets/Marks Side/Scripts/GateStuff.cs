using UnityEngine;
using System.Collections;

public class GateStuff : MonoBehaviour {
	public NavMeshObstacle gate;
	// Use this for initialization
	void Start () {
		gate = GetComponent<NavMeshObstacle>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			GetComponent<NavMeshObstacle>().carving = false;
		}
	}
}

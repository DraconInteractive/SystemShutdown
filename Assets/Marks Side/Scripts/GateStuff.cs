using UnityEngine;
using System.Collections;

public class GateStuff : MonoBehaviour {
	public NavMeshObstacle gate;

	void Start () {
		gate = GetComponent<NavMeshObstacle>();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			GetComponent<NavMeshObstacle>().carving = false;
		}
	}
}

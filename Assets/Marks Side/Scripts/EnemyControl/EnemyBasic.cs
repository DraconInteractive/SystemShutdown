using UnityEngine;
using System.Collections;

public class EnemyBasic : MonoBehaviour {
	private NavMeshAgent myAgent;
	private Vector3 baseLocal;
	public int dmg, health;


	void Start () {
		myAgent = GetComponent <NavMeshAgent> ();
		baseLocal = GameObject.FindGameObjectWithTag ("Base").transform.position;
		myAgent.SetDestination (baseLocal);
		SetHealth ();
	}

	void Update () {
		baseLocal = GameObject.FindGameObjectWithTag ("Base").transform.position;
		myAgent.SetDestination (baseLocal);
	}

	void OnTriggerEnter(Collider other){
		ChangeEnemyNumber ();
		Debug.Log ("true");
	}

	public void RecieveDamage(int projDamage){
		health -= projDamage;
		if (health <= 0) {
			ChangeEnemyNumber ();
		}
	}

	public virtual void SetHealth(){

	}

	public virtual void ChangeEnemyNumber(){

	}
	
}

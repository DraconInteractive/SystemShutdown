using UnityEngine;
using System.Collections;

public class MainTurretScript2 : MonoBehaviour {
	public float detectionRadius, turretRange, fireWait, firingForce;
	public GameObject[] allTargets;
	public GameObject target, projectile, projectileSpawn;
	public Transform thisTransform;
	public bool canFire;
	// Use this for initialization
	void Start () {
		thisTransform = GetComponent<Transform>();
		canFire = true;
	}
	
	// Update is called once per frame
	void Update () {
		LookAtEnemy();
		FireAtEnemy();
	}

	public virtual void LookAtEnemy(){
		allTargets = GameObject.FindGameObjectsWithTag("Enemy");
		if (allTargets == null){
			return;
		}
		float closestDist = 1000;
		foreach (GameObject i in allTargets){
			if (Vector3.Distance(transform.position, i.transform.position) < closestDist){
				closestDist = Vector3.Distance(transform.position, i.transform.position);
				target = i;
			}
		}
		if (target != null)
			thisTransform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
	}

	public virtual void FireAtEnemy(){
		if (target != null){
			if (canFire){
				if (target.gameObject.tag == "Enemy"){
					if (Vector3.Distance(transform.position, target.transform.position) < turretRange){
						GameObject i = Instantiate(projectile.gameObject, projectileSpawn.transform.position, Quaternion.identity) as GameObject;
						i.GetComponent<Rigidbody>().AddForce(transform.forward * firingForce, ForceMode.Impulse);
						StartCoroutine("FireTimer");
					}
				}
			} 
		}
	}

	public IEnumerator FireTimer(){
		canFire = false;
		yield return new WaitForSeconds(fireWait);
		canFire = true;
	}
}

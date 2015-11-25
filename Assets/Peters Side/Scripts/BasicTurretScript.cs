using UnityEngine;
using System.Collections;

public class BasicTurretScript : MainTurretScript2 {

	public override void LookAtEnemy(){
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
		
		thisTransform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
	}
	
	public override void FireAtEnemy(){
		if (target){
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
}

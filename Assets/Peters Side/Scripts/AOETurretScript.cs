using UnityEngine;
using System.Collections;

public class AOETurretScript : MainTurretScript2 {
	public GameObject projectileSpawnTwo, projectileSpawnThree, projectileSpawnFour, projectileSpawnFive, projectileSpawnSix, projectileSpawnSeven, projectileSpawnEight, projectileSpawnNine, projectileSpawnTen, projectileSpawnEleven, projectileSpawnTwelve, projectileSpawnThirteen, projectileSpawnFourteen, projectileSpawnFifteen, projectileSpawnSixteen;

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
	}
	
	public override void FireAtEnemy(){
		if (target){
			if (canFire){
				if (target.gameObject.tag == "Enemy"){
					if (Vector3.Distance(transform.position, target.transform.position) < turretRange){
						GameObject a = Instantiate(projectile.gameObject, projectileSpawn.transform.position, Quaternion.identity) as GameObject;
						GameObject b = Instantiate(projectile.gameObject, projectileSpawnTwo.transform.position, Quaternion.identity) as GameObject;
						GameObject c = Instantiate(projectile.gameObject, projectileSpawnThree.transform.position, Quaternion.identity) as GameObject;
						GameObject d = Instantiate(projectile.gameObject, projectileSpawnFour.transform.position, Quaternion.identity) as GameObject;
						GameObject e = Instantiate(projectile.gameObject, projectileSpawnFive.transform.position, Quaternion.identity) as GameObject;
						GameObject f = Instantiate(projectile.gameObject, projectileSpawnSix.transform.position, Quaternion.identity) as GameObject;
						GameObject g = Instantiate(projectile.gameObject, projectileSpawnSeven.transform.position, Quaternion.identity) as GameObject;
						GameObject h = Instantiate(projectile.gameObject, projectileSpawnEight.transform.position, Quaternion.identity) as GameObject;

						GameObject i = Instantiate(projectile.gameObject, projectileSpawnNine.transform.position, Quaternion.identity) as GameObject;
						GameObject j = Instantiate(projectile.gameObject, projectileSpawnTen.transform.position, Quaternion.identity) as GameObject;
						GameObject k = Instantiate(projectile.gameObject, projectileSpawnEleven.transform.position, Quaternion.identity) as GameObject;
						GameObject l = Instantiate(projectile.gameObject, projectileSpawnTwelve.transform.position, Quaternion.identity) as GameObject;
						GameObject m = Instantiate(projectile.gameObject, projectileSpawnThirteen.transform.position, Quaternion.identity) as GameObject;
						GameObject n = Instantiate(projectile.gameObject, projectileSpawnFourteen.transform.position, Quaternion.identity) as GameObject;
						GameObject o = Instantiate(projectile.gameObject, projectileSpawnFifteen.transform.position, Quaternion.identity) as GameObject;
						GameObject p = Instantiate(projectile.gameObject, projectileSpawnSixteen.transform.position, Quaternion.identity) as GameObject;


						a.GetComponent<Rigidbody>().AddForce((projectileSpawn.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						b.GetComponent<Rigidbody>().AddForce((projectileSpawnTwo.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						c.GetComponent<Rigidbody>().AddForce((projectileSpawnThree.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						d.GetComponent<Rigidbody>().AddForce((projectileSpawnFour.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						e.GetComponent<Rigidbody>().AddForce((projectileSpawnFive.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						f.GetComponent<Rigidbody>().AddForce((projectileSpawnSix.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						g.GetComponent<Rigidbody>().AddForce((projectileSpawnSeven.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						h.GetComponent<Rigidbody>().AddForce((projectileSpawnEight.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						i.GetComponent<Rigidbody>().AddForce((projectileSpawnNine.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						j.GetComponent<Rigidbody>().AddForce((projectileSpawnTen.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						k.GetComponent<Rigidbody>().AddForce((projectileSpawnEleven.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						l.GetComponent<Rigidbody>().AddForce((projectileSpawnTwelve.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						m.GetComponent<Rigidbody>().AddForce((projectileSpawnThirteen.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						n.GetComponent<Rigidbody>().AddForce((projectileSpawnFourteen.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						o.GetComponent<Rigidbody>().AddForce((projectileSpawnFifteen.transform.position - transform.position) * firingForce, ForceMode.Impulse);
						p.GetComponent<Rigidbody>().AddForce((projectileSpawnSixteen.transform.position - transform.position) * firingForce, ForceMode.Impulse);



						StartCoroutine("FireTimer");
					}
				}
			} 
		}
	}
}

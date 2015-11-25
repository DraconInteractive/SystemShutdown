using UnityEngine;
using System.Collections;

public class OnType3 : EnemyBasic {

	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE3 -= 1;
		Destroy (gameObject);
	}
}

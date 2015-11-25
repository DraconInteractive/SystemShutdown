using UnityEngine;
using System.Collections;

public class OnType2 : EnemyBasic {


	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE2 -= 1;
		Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class OnType1 : EnemyBasic {

	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE1 -= 1;
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth> ().baseHealth -= 1;
		Destroy (gameObject);
	}
	public override void SetHealth(){
		health = 1;
		dmg = 1;
	}

}

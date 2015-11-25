using UnityEngine;
using System.Collections;

public class OnType3 : EnemyBasic {

	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE3 -= 1;
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth> ().baseHealth -= 3;
		Destroy (gameObject);
	}
	public override void SetHealth(){
		health = 3;
		dmg = 3;
	}
}

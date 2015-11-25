using UnityEngine;
using System.Collections;

public class OnType2 : EnemyBasic {


	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE2 -= 1;
		GameObject.FindGameObjectWithTag ("Base").GetComponent <BaseHealth> ().baseHealth -= 2;
		Destroy (gameObject);
	}
	public override void SetHealth(){
		health = 2;
		dmg = 2;
	}
}

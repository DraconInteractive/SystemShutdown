using UnityEngine;
using System.Collections;

public class BaseHealth : MonoBehaviour {
	public int baseHealth, totalPower, power, timerMin, nTowers;
	public float timerSec;


	void Start () {
		baseHealth = 100;
		timerSec = 0;
		totalPower = 100;
		nTowers = 30;
		power = (-nTowers*timerMin) + totalPower;
	}

	void Update () {
		Debug.Log ("Base = " + baseHealth);

		timerSec += Time.deltaTime;
		if (timerSec > 60) {
			timerSec = 0;
			timerMin ++;
			power = (-nTowers*timerMin) + totalPower;
		}

		Debug.Log ("Mins = " + timerMin + " Power = " + power);
	}
}

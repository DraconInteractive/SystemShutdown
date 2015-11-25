using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseHealth : MonoBehaviour {
	public int baseHealth, totalPower, power, timerMin, nTowers;
	public float timerSec;

	public List<GameObject> nArray = new List<GameObject>();


	void Start () {
		baseHealth = 100;
		timerSec = 0;
		totalPower = 100;
		power = (-nTowers*timerMin) + totalPower;

		GameObject[] towerArray = GameObject.FindGameObjectsWithTag ("Tower");
		foreach (GameObject i in towerArray) {
			if (nArray.Contains(i)){

			} else {
				nArray.Add (i.gameObject);
			}
		}

		nTowers = nArray.Count;
	}

	void Update () {

		nTowers = nArray.Count;

		Debug.Log ("Base = " + baseHealth);
		Debug.Log ("Towers = " + nTowers);

		timerSec += Time.deltaTime;
		if (timerSec > 60) {
			timerSec = 0;
			timerMin ++;
			power = (-nTowers*timerMin) + totalPower;
		}

		Debug.Log ("Mins = " + timerMin + " Power = " + power);
	}

	public void AddToList (GameObject other)
	{
		nArray.Add (other);
	}

	public void RemoveFromList (GameObject other)
	{
		nArray.Remove (other);
	}
}

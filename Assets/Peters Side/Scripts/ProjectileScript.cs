using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	public float lifeTime;
	// Use this for initialization
	void Start () {
		StartCoroutine("LifeTimer");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.tag == "Enemy"){
			Destroy(this.gameObject);
		}
	}

	public IEnumerator LifeTimer(){
		yield return new WaitForSeconds(lifeTime);
		Destroy(this.gameObject);
	}

}

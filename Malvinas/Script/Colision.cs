using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision coll) {
		Debug.Log ("joel puto");
		Application.LoadLevel("menu");
	}

}

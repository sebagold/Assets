using UnityEngine;
using System.Collections;

public class MoverAlCentro : MonoBehaviour {

	public GameObject destino;
	public int velocidad;

	// Use this for initialization
	void Start () {	

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.transform.position = Vector3.MoveTowards (this.transform.position, destino.transform.position, velocidad * Time.deltaTime);
	}
}

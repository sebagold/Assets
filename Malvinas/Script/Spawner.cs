using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject destino;
	public GameObject prefab;
	public int tiempo;
	private int i;

	// Use this for initialization
	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		if (i > tiempo) {
			this.GetComponent<RandomPosition>().listo = false;
			i = 0;
			GameObject ob = Instantiate (prefab);
			ob.transform.position = this.transform.position;
			ob.GetComponent<MoverAlCentro> ().destino = this.destino;
		}
	}
}

using UnityEngine;
using System.Collections;

public class ColisionParticulas : MonoBehaviour {

	public GameObject objetoColision;
	public GameObject texto;
	public int contador;
	
	void OnParticleCollision(GameObject other) {
		if (other.name == objetoColision.name) {	
			if (contador > 0){
				contador--;
				texto.GetComponent<TextMesh> ().text = contador.ToString();
			}
		}
	}

	public int getContador(){
		return contador;
	}
}

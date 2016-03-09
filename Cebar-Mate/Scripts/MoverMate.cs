using UnityEngine;
using System.Collections;

public class MoverMate : MonoBehaviour {

	private bool derecha;
	RectTransform rectangulo;
	Vector3 screenPos;

	// Use this for initialization
	void Start () {
		derecha = false;
		Random.seed = (int)System.DateTime.Now.Ticks;
		int random = Random.Range (0, 28) - 14;
		this.transform.Translate(new Vector2(random,this.transform.position.y)); 
		screenPos = Camera.main.WorldToScreenPoint(transform.position);
	}

	// Update is called once per frame
	void FixedUpdate () {
		screenPos = Camera.main.WorldToScreenPoint(transform.position);
		if (derecha) {
			moverDerecha ();
		} else {
			moverIzquierda();
		}
		verificar ();
	}

	private void verificar(){
		if(screenPos.x < 0)
			derecha = true;
		else if(screenPos.x > Screen.width)
			derecha = false;
	}

	private void moverDerecha(){
		this.transform.Translate (new Vector2 (0.05f,0));
	}

	private void moverIzquierda(){
		this.transform.Translate (new Vector2 (-0.05f,0));
	}

}

using UnityEngine;
using System.Collections;

public class Seleccionar : MonoBehaviour {

	public GameObject Cebar;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 || Input.GetMouseButton(0)) {
			Vector2 tocadoPantalla = new Vector2();
			if (Input.touchCount > 0)
				tocadoPantalla = Input.GetTouch (0).position; 
			if (Input.GetMouseButton(0))
				tocadoPantalla = Input.mousePosition; 
			Vector2 tocadoMundo = Camera.main.ScreenToWorldPoint(tocadoPantalla);

			SpriteRenderer cebar = Cebar.GetComponent<SpriteRenderer>();
			
			if(cebar.bounds.Contains(tocadoMundo)){
				Application.LoadLevel("Cebar-mate");
			}


		
		}
	}
}

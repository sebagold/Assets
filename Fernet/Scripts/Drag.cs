using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {

	public GameObject fernet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 || Input.GetMouseButton (0)) {
			Vector2 tocadoPantalla = new Vector2 ();
			if (Input.touchCount > 0)
				tocadoPantalla = Input.GetTouch (0).position; 
			if (Input.GetMouseButton (0))
				tocadoPantalla = Input.mousePosition; 
			Vector2 tocadoMundo = Camera.main.ScreenToWorldPoint (tocadoPantalla);

			SpriteRenderer fernetSprite = fernet.GetComponent<SpriteRenderer> ();

			if (fernetSprite.bounds.Contains (tocadoMundo)) {
				float step = 1000000 * Time.deltaTime;
				fernet.transform.position = Vector2.MoveTowards (fernet.transform.position, tocadoMundo, step);
			}
		}
	}
}

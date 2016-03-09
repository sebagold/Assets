using UnityEngine;
using System.Collections;

public class AcelerometroTermo : MonoBehaviour 
{
	void Update () 
	{
		Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
		double width = this.GetComponent<Renderer> ().bounds.size.x;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.3f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0.3f, 0, 0);
		}
		if ((Input.acceleration.x < 0 && screenPos.x > width/2)
		    || (Input.acceleration.x > 0 && screenPos.x < Screen.width - width/2)) {
			
			transform.Translate(Input.acceleration.x, 0, 0);

		}
	}
}
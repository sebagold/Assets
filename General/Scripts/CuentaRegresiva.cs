using UnityEngine;
using System.Collections;

public class CuentaRegresiva : MonoBehaviour {

	public float timeLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			timeLeft = 0;
		}
		this.GetComponent<TextMesh> ().text = ((int)timeLeft).ToString();
	}

	public int getTimeLeft(){
		return (int)timeLeft;
	}
}

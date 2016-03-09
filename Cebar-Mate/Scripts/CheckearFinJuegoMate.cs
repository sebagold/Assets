using UnityEngine;
using System.Collections;

public class CheckearFinJuegoMate : MonoBehaviour {

	ColisionParticulas scriptColision;
	public GameObject objetoScriptColision;
	CuentaRegresiva scriptCuentaRegresiva;
	public GameObject objetoScriptCuentaRegresiva;

	// Use this for initialization
	void Start () {
		scriptColision = objetoScriptColision.GetComponent<ColisionParticulas>();
		scriptCuentaRegresiva = objetoScriptCuentaRegresiva.GetComponent<CuentaRegresiva>();
	}
	
	// Update is called once per frame
	void Update () {
		if (scriptColision.getContador () == 0) {
			Application.LoadLevel("menu");
		}
		if (scriptCuentaRegresiva.getTimeLeft () == 0) {
			Application.LoadLevel("menu");
		}
	}
}

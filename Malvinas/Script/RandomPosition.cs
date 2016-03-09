using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

	public bool listo;


	// Use this for initialization
	void Start () {
		listo = false;
		Random.seed = (int)System.DateTime.Now.Ticks;
	}
	
	// Update is called once per frame
	void Update () {
		if (!listo) {
			Bounds bandaLimite = getCameraBounds (1.5f);
			Bounds bandasSpawn = getCameraBounds (3);


			float posX = Random.Range (bandasSpawn.min.x, bandasSpawn.max.x);
			float posY = Random.Range (bandasSpawn.min.y, bandasSpawn.max.y);

			Vector3 puntoSpawn = new Vector3 (posX, posY, 0);

			puntoSpawn = sacarDeCamara (bandaLimite, puntoSpawn);

			this.transform.position = puntoSpawn;
	
			listo = true;
		}
	}

	private Vector3 sacarDeCamara(Bounds borde, Vector3 punto){
		while(borde.Contains (punto)) {
			if (punto.x >= 0)
				punto.x += 0.25f;
			else
				punto.x -= 0.25f;
			if (punto.y >= 0)
				punto.y += 0.25f;
			else
				punto.y -= 0.25f;
		}
		return punto;
	}

	private Bounds getCameraBounds(float diff){
		float x = Camera.main.transform.position.x;
		float y = Camera.main.transform.position.y;
		float size = Camera.main.orthographicSize * 2;
		float width = (size * (float)Screen.width / Screen.height);
		float height = size;
		return new Bounds(new Vector3(x, y, 0), new Vector3(width+diff, height+diff, 0));
	}
}

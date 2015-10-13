using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {
	public Renderer r;


	// Use this for initialization
	void Start () {
		r = GetComponent<Renderer> ();
		r.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		float b = Random.Range (0, 100);
		if (b < 1) {
			r.enabled = true;
		} else {
			r.enabled = false;
		}

		//bool trig = Mathf.FloorToInt(Time.time) % 2 == 0;
		//r.enabled = trig;
	}
}

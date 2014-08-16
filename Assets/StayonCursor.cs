using UnityEngine;
using System.Collections;

public class StayonCursor : MonoBehaviour {
	public static Vector3 cursorposition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		cursorposition = camera.ScreenToWorldPoint(Input.mousePosition);
		//camera z offset for 2d
		cursorposition.z += 10;
	

	
	}
}

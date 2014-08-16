using UnityEngine;
using System.Collections;

public class Cameracursorlocator : MonoBehaviour {

	public static Vector3 cursorposition;
	public Vector3 viewportposition;
	public Ray testingposition;
	public Vector3 displayercursorposition;
	public bool output = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		cursorposition = camera.ScreenToWorldPoint(Input.mousePosition);
		viewportposition = camera.ScreenToViewportPoint(Input.mousePosition);
		testingposition = camera.ScreenPointToRay(Input.mousePosition);


		displayercursorposition = cursorposition;
		//camera z offset for 2d
		cursorposition.z += 10;
	
		if (output) {
			print("The one from the camera: " + cursorposition);
				}


		
		
	}
}

using UnityEngine;
using System.Collections;

public class testmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 myvector = new Vector2 (2, 0);

		rigidbody2D.velocity = myvector;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

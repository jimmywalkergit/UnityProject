using UnityEngine;
using System.Collections;

public class shootparticle : MonoBehaviour {
	public Vector3 startposition;
	public Vector3 endposition;



	public Vector3 endingPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		startposition = gameObject.transform.position;
		//endposition = StayonCursor.cursorposition;

		//endposition = Vector3.MoveTowards (transform.position, StayonCursor.cursorposition, 10f);
	
		endposition = StayonCursor.cursorposition;



		transform.position = endposition;




	}








}

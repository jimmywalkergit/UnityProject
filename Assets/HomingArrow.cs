using UnityEngine;
using System.Collections;

public class HomingArrow : MonoBehaviour {

	public Vector3 startposition;
	public Vector3 endposition;
	
	public Vector3 deadzone;
	
	
	public Vector3 endingPoint;
	
	// Use this for initialization
	void Start () {
		
		deadzone.x = .2f;
		deadzone.y = .2f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
		
		
		
		
	}


	void FixedUpdate(){
		
		startposition = gameObject.transform.position;
		
		endposition = StayonCursor.cursorposition;
		
		
	//	if(Mathf.Abs(startposition.x - endposition.x) > deadzone.x 
	//	   && Mathf.Abs(startposition.y  - endposition.y) > deadzone.y){
			
			transform.position = endposition;
	//	}

		
		
	}




}

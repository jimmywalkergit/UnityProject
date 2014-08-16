using UnityEngine;
using System.Collections;

public class TouchPlayerMovement : MonoBehaviour {


	
	
	private Animator myanim;
	
	public bool canmove = true;
	
	
	
	public float speed = 1;
	
	private Vector2 movement;
	void Awake(){
		
		
		
		
		
		
		
		
	}
	
	
	
	
	
	void Update()
	{
		
		
	}
	
	void FixedUpdate()
	{

		
		
		float directionx = Input.GetAxis ("Horizontal");
		float directiony = Input.GetAxis ("Vertical");
		myanim = GetComponent<Animator>();
		myanim.SetFloat ("Speed", directionx);
		myanim.SetFloat ("Speedy", directiony);
		
		movement.x = directionx*speed;
		movement.y = directiony*speed;
		
		
		
		
		if (canmove) {
			
			rigidbody2D.velocity = movement;
			
			
			
			
		} else {
			
			
			
			
			
		}
		
		
		
		
		
		
		
		
		
		
		
	}
	
	
	void OnTriggerEnter2D(Collider2D othercollider){
		
		
		//executed when another triggercollider is touching
		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties>();
		
		
		
		if (otherproperties != null) {
			
			
			
			
			
			
			
			
			
			
			
			
			
		} 
		
		
	}
	
	void OnTriggerExit2D(Collider2D othercollider){
		//executed when another triggercollider is no longertouching
		
		//		myProperties otherproperties = othercollider.gameObject.GetComponent<myProperties>();
		
		
		
		
		
		
	}
	
	
	
	void setmovement(bool canimove){
		
		canmove = canimove;
		
	}
	

}

using UnityEngine;
using System.Collections;


public class MonsterMove : MonoBehaviour {

	public Vector2 walkup = new Vector2(0,2);
	public Vector2 walkdown = new Vector2(0,-2);
	public Vector2 walkright = new Vector2(2,0);
	public Vector2 walkleft = new Vector2(-2,0);
	public float movetimer = 3f;

	public float direction;
	private Animator myanim;


	void Awake() {
		//executed when object is created
		

		
		
	}
	
	
	
	void Start () {
		//executed after awake

	
		
		
	}
	
	void Update () {
		//executed every frame




			float myrandom = Random.Range(0,100);


		movetimer -= Time.deltaTime;

		//time to change direction




		if(movetimer <= 0){

				if (myrandom <= 25){
					rigidbody2D.velocity = walkup;
					
					
					
				} else if(myrandom > 25 && myrandom <= 50){
				rigidbody2D.velocity = walkdown;
				
					
					
					
				}else if (myrandom > 50 && myrandom <= 75){
					
				rigidbody2D.velocity = walkleft;

					
					
				} else if (myrandom > 75 && myrandom <= 100){
					
				rigidbody2D.velocity = walkright;

					
				}

			movetimer = 3f;



			}





			
		



		direction = this.rigidbody2D.velocity.x;
		myanim = GetComponent<Animator>();
		myanim.SetFloat ("Speed", direction);

		
		
	}
	
	
	void Fixedupdate() {
		//executed each fixed framerate, rigidbody

	

			




		
	}
	

	
	void OnTriggerEnter2D(Collider2D otherCollider){
		//executed when another triggercollider is touching
		
	}
	
	void OnTriggerExit2D(Collider2D otherCollider){
		//executed when another triggercollider is no longertouching
		
	}
	
	
	

}

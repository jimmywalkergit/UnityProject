using UnityEngine;
using System.Collections;

public class Properties : MonoBehaviour  {
	public bool isplayer = false;
	public bool hurtsplayer;
	public int mytimeout;
	public float damage = 0;
	public float health = 1;

	// Use this for initialization
	void Start () {

		//start projectile life on creation
		if (mytimeout > 0)
						Destroy (this.gameObject, mytimeout);




	
	}
	
	// Update is called once per frame
	void Update () {



	
	}

	void FixedUpdate(){
		//checkdeath
		if (this.health <= 0) {

			Destroy (this.gameObject);
				}

	
	
	}

	void OnTriggerEnter2D(Collider2D otherCollider){
		//executed when another triggercollider is touching
		
	

		
		
		
		
		
		
		
		
	}




		}


	



using UnityEngine;
using System.Collections;

public class myProperties : MonoBehaviour {

	public float mytimeout;
	public bool isplayer = false;
	public bool iskillable = true;
	public bool hasexpbar = false;
	public bool hashealthbar = false;
	public float mylevel = 1;
	public float myexp;

	public float totalhp;
	public float hp = 0;


	public float exp;
	public float deathexp = 0;
	public string myname;
	private Vector3 healthScale, expscale;
	private float expneeded = 100;
	public SpriteRenderer myhealthbarsprite, myexpbarsprite;




	void Awake() {
		//executed when object is created

		//destroy after timeout if timeout
		if (mytimeout > 0) {
			Destroy (gameObject, mytimeout);
				}
		if (hashealthbar) {
			healthScale = myhealthbarsprite.transform.localScale;
		}

		if (hasexpbar) {
			expscale = myexpbarsprite.transform.localScale;
			UpdateExpBar();

				}

		
	}
	
	
	
	void Start () {
		//executed after awake
	

		
		totalhp = hp;
		
	}
	
	void Update () {
		//executed every frame
		
		
		
	}
	
	
	void Fixedupdate() {
		//executed each fixed framerate, rigidbody



		
	}
	
	
	void OnCollisionEnter2D(Collision2D othercollider){
		//executed when another collider is touching

	}
	
	void OnCollisionExit2D(Collision2D othercollider){
		//executed when another collider is no longer touching
		
	}
	
	void OnTriggerEnter2D(Collider2D othercollider){
		//executed when another triggercollider is touching

		



		
	}
	
	void OnTriggerExit2D(Collider2D othercollider){
		//executed when another triggercollider is no longertouching
		
	}

	public void gainexp(float otherexp){


		exp += otherexp;
		UpdateExpBar ();
		if (exp >= 100) {
	print("***WOW OMG OMG OMG !!!!!! YOU LEVELED UP !!!!!!!! OMG OMG OMG WOW***");
			mylevel += 1;

		expneeded = exp + 10;
		exp -= exp;

			UpdateExpBar ();
				}

		}
	
	public void dealdamage(float thedamage){
				//deal damage, if not enough health you die
				if (iskillable) {




						hp -= thedamage;
			UpdateHealthBar();

						print ("dealt " + thedamage + "points of damage to   " + myname + "   hp remaining: " + hp);
						

			if (hp <= 0) {
								Destroy (gameObject);

						}



				}
		}

	private void UpdateHealthBar ()
	{

if (hashealthbar) {

		
	
			myhealthbarsprite.transform.localScale = new Vector3( hp/totalhp, 1, 1);



				}


	
	}

	private void UpdateExpBar ()
	{
		
		if (hasexpbar) {
			
			

			myexpbarsprite.transform.localScale = new Vector3( exp/expneeded, 1, 1);
			
			
			
		}
		
		
		
	}




}

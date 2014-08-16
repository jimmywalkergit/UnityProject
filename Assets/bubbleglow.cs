using UnityEngine;
using System.Collections;

public class bubbleglow : MonoBehaviour {
	public SpriteRenderer mysprite; 

	public float timer, timeout = .5f;
	public Color fadercolor;
	public bool increaseglow = false, decreaseglow = true;
	// Use this for initialization
	void Start () {
	


	}


	void Awake(){

		mysprite = gameObject.GetComponent<SpriteRenderer> ();


		fadercolor = mysprite.color;

		}
	// Update is called once per frame
	void Update () {
	

		timer += Time.deltaTime;

	

		if (timer > timeout && decreaseglow) {
			timer = 0;

			fadercolor.a = mysprite.color.a - .05f;
			mysprite.color = fadercolor;

			if(mysprite.color.a < .1f){


				print ("start increasing");
				increaseglow = true; 
				decreaseglow = false;

			}





				}

		if (timer > timeout && increaseglow) {
			fadercolor.a = mysprite.color.a + .05f;
			mysprite.color = fadercolor;

			if (mysprite.color.a >= .95f){


			print ("start decreasing");
			decreaseglow = true;
			increaseglow = false;
				}




	}
	}
}
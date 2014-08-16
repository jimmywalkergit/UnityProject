using UnityEngine;
using System.Collections;

public class ShootProjectile : MonoBehaviour {


	public Rigidbody2D projectile;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//shoot arrow
		if (Input.GetButtonDown ("Fire1")) {
			
			
			
			//shoots arrows in 8 directions according to rigidbody movement
			
			
			if (this.rigidbody2D.velocity.x >= 0 && this.rigidbody2D.velocity.y == 0){
				//shoot right
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(5, 0);
				
			}else if (this.rigidbody2D.velocity.x == 0 && this.rigidbody2D.velocity.y > 0){
				//shoot right
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(5, 0);
				
				
			}else if (this.rigidbody2D.velocity.x == 0 && this.rigidbody2D.velocity.y < 0){
				//shoot right
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(5, 0);
				
				
			}else if(this.rigidbody2D.velocity.x < 0 && this.rigidbody2D.velocity.y == 0){
				//shoot left
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(-5, 0);
				
			} else if (this.rigidbody2D.velocity.x >= 0 && this.rigidbody2D.velocity.y > 0){
				//shoot upright
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(5, 5);
				
			}else if (this.rigidbody2D.velocity.x <= 0 && this.rigidbody2D.velocity.y < 0){
				//shoot down left
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(-5, -5);
				
			}else if (this.rigidbody2D.velocity.x >= 0 && this.rigidbody2D.velocity.y < 0){
				//shoot down right
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(5, -5);
				
			}else if (this.rigidbody2D.velocity.x <= 0 && this.rigidbody2D.velocity.y > 0){
				//shoot upleft
				Rigidbody2D arrowInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				arrowInstance.velocity = new Vector2(-5, 5);
				
			}
			
			
			//end shoot arrow
			

	
	}
}

}

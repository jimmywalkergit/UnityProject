using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour {
	public Rigidbody2D AMonster;

	public bool enablerandommotion = false;
	public float spawncooldown = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (spawncooldown <= 0) {
						Rigidbody2D monsterinstance = Instantiate (AMonster, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Rigidbody2D;
						monsterinstance.velocity = new Vector2 (2, 0);


			spawncooldown = 3f;

				} else {

			spawncooldown -= Time.deltaTime;
				}



	
	}
}

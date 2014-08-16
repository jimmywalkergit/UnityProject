using UnityEngine;
using System.Collections;

public class CreatePrefabOnClick : MonoBehaviour {

	public Rigidbody2D prefabToCreate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetButtonDown ("Fire1")) {
	
		
				Rigidbody2D InstancePrefab = Instantiate(prefabToCreate, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;

			
			
		
	}

}
}
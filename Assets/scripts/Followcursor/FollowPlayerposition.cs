using UnityEngine;
using System.Collections;

public class FollowPlayerposition : MonoBehaviour {
	
	public Transform playertransform;
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (playertransform != null) {
			
			Vector3 playerfollowposition;
			playerfollowposition = playertransform.position;
			
			
			
		//camera z offset
			playerfollowposition.z -= 10;
			
			
			this.gameObject.transform.position = playerfollowposition;
		}
		
		
		
		
		
		
	}
}

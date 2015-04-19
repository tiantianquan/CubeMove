using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
//				this.rigidbody.AddForce(new Vector3(1000f,1000f,0f));
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision) 
	{
		this.rigidbody.AddForce(new Vector3(0f,1000f,0f));
	}
}

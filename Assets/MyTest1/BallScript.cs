using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	private Rigidbody rb;
	private float speed;

	// Use this for initialization
	void Start () {
		speed = 1;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveInput = Input.GetAxis("Horizontal") ;
		float moveInput2 = Input.GetAxis("Vertical") ;
		float moveInput3 = 0.0f;
		if(Input.GetKey(KeyCode.Space)){
			moveInput3 = 10f;
		}
		rb.AddForce(new Vector3(moveInput,moveInput3,moveInput2)*speed);
	}

	void OnCollisionEnter(Collision collision) 
	{
//		this.rigidbody.AddForce(new Vector3(0f,100f,0f));
	}
}

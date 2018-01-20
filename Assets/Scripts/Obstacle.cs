using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Vector2 moveSpeed = new Vector2(-4.0f,0.0f);
	public float range = 2.0f;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = moveSpeed;
		transform.position = new Vector3 (transform.position.x, 
		                                  transform.position.y - range * Random.value,
		                                  transform.position.z);
		Destroy (gameObject, 20.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

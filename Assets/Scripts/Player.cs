using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public AudioClip jumpSound;
	public Vector2 jumpForce = new Vector2(0,300);

	public AudioClip dieSound;
	private bool isDie = false;
	private float timer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			audio.clip = jumpSound;
			if(!audio.isPlaying)
				audio.Play();

			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);

		if (screenPosition.y < 0 || screenPosition.y > Screen.height) {
			isDie = true;
		
		}

		if (isDie) {
			audio.clip =dieSound;
			if(!audio.isPlaying)
				audio.Play();
		
			timer += Time.deltaTime;
			if(timer >= 0.25f)
				Application.LoadLevel(Application.loadedLevel);        //调用上一次运行的场景/关卡
		}
	}

	void OnCollisionEnter2D(){

		isDie = true;
	}
}

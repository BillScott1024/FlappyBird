using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {


	public GameObject rocks;
	private int score = 0;
	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("CreateObstacle", 1.0f, 1.5f);
	}
	void OnGUI(){
		GUI.color = Color.green;
		GUILayout.Label ("Score:" + score.ToString ());

	
	}
	// Update is called once per frame
	void CreateObstacle(){
		Instantiate (rocks);
		score++;
	}
}

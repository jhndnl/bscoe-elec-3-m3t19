using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour {

	Rigidbody _rigidBody;

	void Start () {
		_rigidBody = GetComponent<Rigidbody>();

	}
	

	void Update () {
		ProcessInput ();

	}

	private void ProcessInput(){
		if (Input.GetKey(KeyCode.Space)){
			_rigidBody.AddRelativeForce(Vector3.up);
		}
		if (Input.GetKey(KeyCode.A)){

			transform.Rotate(Vector3.forward);
		}
	
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(-Vector3.forward);
		}
		if (Input.GetKey (KeyCode.O)) {

			SceneManager.LoadScene ("Level1");
		}

	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Ceiling" || col.gameObject.name == "Left Wall" || col.gameObject.name == "Right Wall" || 
			col.gameObject.name == "Terrain" || col.gameObject.name == "Cube" || col.gameObject.name == "Cube1" || col.gameObject.name == "Cube2" ||
			col.gameObject.name == "Cube3" || col.gameObject.name == "Cube4" || col.gameObject.name == "Cube5" || col.gameObject.name == "Cube6"|| col.gameObject.name == "Cube7" ) 
		{
			SceneManager.LoadScene ("Level1");
	}
		if (col.gameObject.name == "target pad") {
			col.gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}
}
}
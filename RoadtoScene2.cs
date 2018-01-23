using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadtoScene2 : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{


		if (col.gameObject.name == "Rocket Ship") {
			SceneManager.LoadScene ("Level2");

		}

	}
}
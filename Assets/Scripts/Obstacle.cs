using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour 
{
	void				OnTriggerEnter(Collider other)
	{
		Debug.Log ("YOU DIE");
		Application.LoadLevel("Game"); 
	}

}

using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	float				speed = 5.0f;
	
	void 				Start () 
	{
	
	}
	
	void 				Update () 
	{
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}

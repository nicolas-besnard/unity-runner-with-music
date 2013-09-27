using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
	public Transform	nextElement;
	float				speed = 10.0f;
	bool				isEnter = false;
	
	void				OnTriggerEnter(Collider other)
	{
		isEnter = true;
	}
	
	void				OnTriggerExit(Collider other)
	{
		isEnter = false;
	}
	
	void				Update()
	{
		if (isEnter)
		{
	    	Camera.main.transform.rotation = Quaternion.Slerp(
					Camera.main.transform.rotation, 
					Quaternion.LookRotation(nextElement.position - Camera.main.transform.position),
					speed * Time.deltaTime);
		}
	}
}

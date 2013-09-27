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
		float			axis;
		
		if ((axis = Input.GetAxis("Vertical")) != 0)
		{
			float y;
			if (axis > 0)
			{
				y = transform.position.y + 1;
			}
			else
			{
				y = transform.position.y - 1;
			}
			
			float		newY = Mathf.Clamp(y, 0.5f, 5.0f);
			Vector3		newPos = new Vector3(transform.position.x, newY, transform.position.z);
			transform.position = Vector3.Lerp(transform.position, newPos, speed * Time.deltaTime);
		}
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}

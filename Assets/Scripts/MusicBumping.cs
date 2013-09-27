using UnityEngine;
using System.Collections;

public class MusicBumping : MonoBehaviour 
{
	public AudioSource		music;
	
	float[]					samples;
	GameObject[]			lights;
	
	void 					Start () 
	{
		lights = GameObject.FindGameObjectsWithTag("Light");
		toggleLights(false);
		samples = new float[64];
	}
	
	void 					Update () 
	{		
		StartCoroutine("test");
	}
	
	IEnumerator				test()
	{
		music.GetSpectrumData(samples, 0, FFTWindow.BlackmanHarris);
		for (int i = 0; i < samples.Length; ++i) 
		{
			if (samples[i] * 100 > 5)
			{
				toggleLights(true);
				yield return new WaitForSeconds(1);
				toggleLights(false);

			}
		}
	}
	
	void					toggleLights(bool setValue)
	{	
		foreach (GameObject light in lights)
		{
			light.SetActive(setValue);
		}
	}
}

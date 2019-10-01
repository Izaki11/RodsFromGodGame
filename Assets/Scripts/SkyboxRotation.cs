using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotation : MonoBehaviour
{
	public float rotationSpeed;
	
	private void Start()
	{
		
	}
	
	private void Update()
	{
		RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
	}
}

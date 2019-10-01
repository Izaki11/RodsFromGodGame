using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	public float rotationSpeed;
	public float tickRate;
	private float nextTick;
	public UIController ui;
	
	private void Start()
	{
		nextTick = Time.time + tickRate;
	}
	
	private void Update()
	{
		gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
		
		if(!ui.isPaused)
		{	
			if(Time.time > nextTick)
			{
				nextTick = Time.time + tickRate;
				
				rotationSpeed++;
			}
		}
	}
}

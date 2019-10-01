using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speedModifier;
	
	private void Update()
	{
		
	}
	
	public void MovementStrafe(Vector3 dir)
	{
		gameObject.transform.RotateAround(Vector3.zero, dir, Time.deltaTime * speedModifier);
	}
}

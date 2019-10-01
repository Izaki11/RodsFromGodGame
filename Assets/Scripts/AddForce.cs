using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
	public float force;
	
	private void Start()
	{
		Force();
	}
	
	private void Force()
	{
		foreach(Transform child in transform)
		{
			Rigidbody rb = child.gameObject.GetComponent<Rigidbody>();
			rb.AddExplosionForce(force, transform.position, 2f, 1f,  ForceMode.Impulse);
		}
	}
}

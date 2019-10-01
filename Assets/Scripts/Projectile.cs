using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public float projectileSpeed;
	private Rigidbody rigidbody;
	public GameObject explosionPrefab;
	
	private void Start()
	{
		rigidbody = gameObject.GetComponent<Rigidbody>();
	}
	
	private void FixedUpdate()
	{
		rigidbody.AddRelativeForce(0, 0, projectileSpeed, ForceMode.Acceleration);
	}
	
	private void OnCollisionEnter(Collision col)
	{
		Rotation rotation = col.collider.gameObject.GetComponent<Rotation>();
		if(rotation != null)
		{
			ContactPoint contact = col.GetContact(0);
			Vector3 position = contact.point;
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			GameObject newExplosion = Instantiate(explosionPrefab, position, rot);
			newExplosion.transform.SetParent(col.collider.transform); 
		}
		Destroy(gameObject);
	}
}

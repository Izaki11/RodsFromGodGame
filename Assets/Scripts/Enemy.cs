using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
	
	public GameObject debris;
	
	private void Awake()
	{
		LifeForce.instance.bunkers.Add(this.gameObject);
	}
	
	private void Start()
	{
		
	}
	
	public void Death()
	{
		LifeForce.instance.bunkers.Remove(this.gameObject);
		LifeForce.instance.score++;
		LifeForce.instance.audSource.Play();
		Instantiate(debris, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}

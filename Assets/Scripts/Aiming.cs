using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
	public Transform barrel;
	public Transform laserBarrel;
	private Camera camera;
	public bool isGameOver;
	
	private void Awake()
	{
		camera = Camera.main;
	}
	
	private void Update()
	{
		if(!isGameOver)
		{
			CalculateAim();
		}
	}
	
	private void CalculateAim()
	{
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Physics.Raycast(ray, out hit, 100))
		{
			barrel.LookAt(hit.point);
			laserBarrel.LookAt(hit.point);
		}
	}
}

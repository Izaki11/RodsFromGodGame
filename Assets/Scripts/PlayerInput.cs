using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
	private KineticFire shootScript;
	public Movement movement;
	private Vector3 moveDirection;
	public bool isGameOver;
	
	private void Awake()
	{
		shootScript = gameObject.GetComponent<KineticFire>();
	}
	
	private void Update()
	{
		if(!isGameOver)
		{
			if(Input.GetMouseButtonDown(0))
			{
				shootScript.Fire();
			}
			
			moveDirection.z = Input.GetAxisRaw("Vertical");
			moveDirection.y = -Input.GetAxisRaw("Horizontal");
			
			movement.MovementStrafe(moveDirection);
		}
		
		if(Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene(0);
			}
	}
}

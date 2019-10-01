using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
	public GameObject titlePanel;
	public GameObject healthBar;
	public GameObject ammoBar;
	private bool isTitle;
	public bool isPaused;
	public GameObject player;
	public GameObject manager;
	
	private void Start()
	{
		InitTitle();
	}
	
	public void InitTitle()
	{
		isPaused = true;
		titlePanel.SetActive(true);
		healthBar.SetActive(false);
		ammoBar.SetActive(false);
		player.SetActive(false);
		manager.SetActive(false);
	}
	
	public void StartGame()
	{
		isPaused = false;
		titlePanel.SetActive(false);
		healthBar.SetActive(true);
		ammoBar.SetActive(true);
		player.SetActive(true);
		manager.SetActive(true);
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}
	
	public void PauseGame()
	{
		
	}
}

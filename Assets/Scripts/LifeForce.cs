using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeForce : MonoBehaviour
{
	public static LifeForce instance;
	
	public float maxLife;
	private bool isGameOver;
	private float _currentLife;
	public float currentLife
	{
		get
		{
			return _currentLife;
		}
		set
		{
			if(value < 0f)
			{
				_currentLife = 0f;
			}
			else if(value > maxLife)
			{
				_currentLife = maxLife;
				GameOver();
			}
			else
			{
				_currentLife = value;
			}
		}
	}
	
	public List<GameObject> bunkers = new List<GameObject>();
	public float multiplier;
	public Image healthBar;
	public int score;
	public TextMeshProUGUI scoreCount;
	public TextMeshProUGUI threatCount;
	public PlayerInput input;
	public Aiming aim;
	public AudioSource audSource;
	public AudioClip deathSound;
	public AudioClip gameOverSound;
	public Animator anim;
	private IEnumerator co;
	
	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}
	}
	
	private void Hacking()
	{
		if(!isGameOver)
		{
			currentLife += bunkers.Count * multiplier * Time.deltaTime;
		}
	}
	
	private void SetHealthBar()
	{
		healthBar.fillAmount = _currentLife / maxLife;
	}
	
	private void Update()
	{
		Hacking();
		SetHealthBar();
		scoreCount.text = "Score: " + score;
		threatCount.text = "Threats: " + bunkers.Count;
	}
	
	private void GameOver()
	{
		isGameOver = true;
		input.isGameOver = true;
		aim.isGameOver = true;
		audSource.clip = gameOverSound;
		audSource.Play();
		co = End();
		StartCoroutine(co);
	}
	
	private IEnumerator End()
	{
		anim.SetTrigger("GameOver");
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene(0);
	}
}

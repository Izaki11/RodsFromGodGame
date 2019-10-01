using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
	public GameObject enemy;
	public Transform parent;
	public float spawnRate;
	private float lastSpawn;
	
	private void Awake()
	{
		
	}
	
	private void Start()
	{
		
	}
	
	private void Update()
	{
		if(Time.time > lastSpawn)
		{
			lastSpawn = Time.time + spawnRate;
			SpawnEnemy();
		}
	}
	
	private void SpawnEnemy()
	{
		float randomZ = Random.Range(0f, 360f);
		float randomY = Random.Range(0f, 360f);
		float randomX = Random.Range(0f, 360f);
		GameObject newEnemy = Instantiate(enemy, Vector3.zero, Quaternion.Euler(randomX, randomY , randomZ));
		newEnemy.transform.position = newEnemy.transform.up * 25.4f;
		newEnemy.transform.SetParent(parent);
	}
	
	public void SpawnInitial(int amount)
	{
		for(int i = 0; i < amount; i++)
		{
			SpawnEnemy();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KineticFire : MonoBehaviour
{
	public Projectile projectile;
	public Transform firePoint;
	public float projectileSpeed;
	private float nextFire;
	public float fireRate;
	private float lastShot;
	public Image ammo;
	private AudioSource audSource;
	public AudioClip shotSound;
	public AudioClip reloadSound;
	
	private void Start()
	{
		nextFire = Time.time + fireRate;
		audSource = gameObject.GetComponent<AudioSource>();
	}
	
	private void Update()
	{
		lastShot += Time.deltaTime;
		ammo.fillAmount = lastShot / fireRate;
	}
	
	public void Fire()
	{
		if(Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			lastShot = 0f;
			audSource.clip = shotSound;
			audSource.Play();
			
			Projectile newProjectile = Instantiate(projectile, firePoint.position, firePoint.rotation);
			newProjectile.projectileSpeed = projectileSpeed;
		}
	}
}

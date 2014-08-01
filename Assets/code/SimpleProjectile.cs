﻿using UnityEngine;
public class SimpleProjectile : projektil {
	public int Damage;
	public GameObject DestroyedEffect;
	public int PointsToGiveToPlayer;
	public float TimeToLive;
    public AudioClip DestroySound;

	public void Update()
	{
		if ((TimeToLive -= Time.deltaTime) <= 0) {
			DestroyProjectile();
			return;
		}
		transform.Translate((Direction + new Vector2(InitialVelocity.x,0))* Speed *Time.deltaTime,Space.World);
		transform.Translate (Direction * ((Mathf.Abs(InitialVelocity.x)+Speed)*Time.deltaTime),Space.World);
	}

	public void TakeDamage(int damage, GameObject instigator)
	{
        
		if (PointsToGiveToPlayer != 0) {
			var projectile= instigator.GetComponent<projektil>();
			if (projectile!=null && projectile.Owner.GetComponent<igrac>()!=null)
			{
				gamemanager.Instance.AddPoints(PointsToGiveToPlayer);
				FloatingText.Show(string.Format("+{0}!", PointsToGiveToPlayer),"PointStarText", new FromWorldPointTextPositioner(Camera.main, transform.position, 1.5f,50));

			}
		}
		DestroyProjectile ();
	}

	protected override void OnCollideOther(Collider2D other)
	{
		DestroyProjectile ();
	}

	protected override void OnCollideTakeDamage(Collider2D other, ITakeDamage takeDamage)
	{
		takeDamage.TakeDamage (Damage, gameObject);
		DestroyProjectile ();
	}

	private void DestroyProjectile()
	{
		if (DestroyedEffect != null)
						Instantiate (DestroyedEffect, transform.position, transform.rotation);
		if (DestroySound!=null)
            AudioSource.PlayClipAtPoint(DestroySound,transform.position);
        
        Destroy (gameObject);
	}
}

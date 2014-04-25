﻿using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {
	public bool hasHitSomething = false;

	//private ComboText comboColor;

	private Level count;
	private ScoreController score;
	private ScoreController comboBlue;
	private ScoreController comboGreen;
	private ScoreController comboOrange;
	private ScoreController comboYellow;
	private ScoreController comboPurple;
	
	void Start () 
	{
		//Initialzation from the ScoreController script
		score = GameObject.Find("Score").GetComponent<ScoreController>();
		comboBlue = GameObject.Find("Score").GetComponent<ScoreController>();
		comboGreen = GameObject.Find("Score").GetComponent<ScoreController>();
		comboOrange = GameObject.Find("Score").GetComponent<ScoreController>();
		comboYellow = GameObject.Find("Score").GetComponent<ScoreController>();
		comboPurple = GameObject.Find("Score").GetComponent<ScoreController>();
		//comboColor = GameObject.Find("comboColor").GetComponent<ComboText>();
	}
	
	void Update () 
	{			

	}






	

	void OnCollisionEnter2D(Collision2D other)
	{

		 
		//If-statement that only makes it possible for the brick to collide with objects under it. 
		if(other.contacts.Length > 0)
		{
			ContactPoint2D contact = other.contacts[0];
			if(Vector3.Dot(contact.normal, Vector3.up) > 0.5)
			{
				Debug.Log("hej");
				//Something needs to tell Instatiater that this object has collided!
				hasHitSomething = true;

				//this is legacy code


			}
		}






		//Detects collison between bricks. 
		//If the colors match it updates score and destroy the colliding bricks.
		if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue")
		{
			Destroy(gameObject);
			comboBlue.comboBlue += 1;
			
			if(comboBlue.comboBlue > 2)
			{
				score.score += 2;
				count.count += 0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
			
			//Resets the other colors combo counters
			comboGreen.comboGreen = 0;
			comboOrange.comboOrange = 0;
			comboYellow.comboYellow = 0;
			comboPurple.comboPurple = 0;
		}
		
		if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green")
		{
			Destroy(gameObject);
			comboGreen.comboGreen += 1;
			
			if(comboGreen.comboGreen > 2)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
			
			comboBlue.comboBlue = 0;
			comboOrange.comboOrange = 0;
			comboYellow.comboYellow = 0;
			comboPurple.comboPurple = 0;
		}
		
		if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange")
		{
			Destroy(gameObject);
			comboOrange.comboOrange += 1;
			
			if(comboOrange.comboOrange > 2)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
			
			comboBlue.comboBlue = 0;
			comboGreen.comboGreen = 0;
			comboYellow.comboYellow = 0;
			comboPurple.comboPurple = 0;
		}
		
		if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow")
		{
			Destroy(gameObject);
			comboYellow.comboYellow += 1;
			
			if(comboYellow.comboYellow > 2)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
			
			comboBlue.comboBlue = 0;
			comboGreen.comboGreen = 0;
			comboOrange.comboOrange = 0;
			comboPurple.comboPurple = 0;
		}
		
		if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple")
		{
			Destroy(gameObject);
			comboPurple.comboPurple += 1;
			
			if(comboOrange.comboOrange > 2)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
			
			comboBlue.comboBlue = 0;
			comboGreen.comboGreen = 0;
			comboOrange.comboOrange = 0;
			comboYellow.comboYellow = 0;
		}


		
	}
	
	
}
﻿//Christian Diaz
//This script is used for the panels that allow players to move between areas.
using UnityEngine;
using System.Collections;

public class Trans_9_10 : MonoBehaviour {
//if the player touches the collider of the component that this script is attached to, this code will run.
//First the World will be checked, and the the player will be found. After the player is located and 
//correctly identified, the player will be transformed from their current location to a different location,
//one that corresponds to a different area.
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Teleport trigger.");
		GameObject world = GameObject.FindGameObjectWithTag("World");
        if(world){
        	//Debug.Log("Found world.");
        	GameObject player = world.GetComponent<GCtrller>().da_player;
        	if(player){
        		//Debug.Log("Found player.");
        		player.GetComponent<Player>().transform.position = new Vector3(-77.19734f, -7.131994f, -2.54f);
       		}
       	}
	}	
}

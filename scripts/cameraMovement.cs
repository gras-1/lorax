using system;
using UnityEngine;
using playermove;

new Vector2 camcoords;
new RigidBody2D rigidbody;



public cameraMovement : MonoBehavour 
{
  if (playermove.coords.x == pixelWidth){
    rigidbody.position = rigidbody.position * Time.FIxedDeltaTime * playermove.movespeed;
  }
}


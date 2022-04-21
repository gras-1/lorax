using system;
using UnityEngine;
using playermove;

new Vector2 camcoords;
new RigidBody2D rigidbody;



public cameraMovement : MonoBehavour 
{
  private float negCamCoordsX = pixelWidth - (pixelWidth * 2);
  private float negCamCoordsY = pixelHeight - (pixelHeight * 2);
  
  if (playermove.coords.x == pixelWidth){
    rigidbody.position = rigidbody.position * Time.FIxedDeltaTime * playermove.movespeed;
  }
  if (playermove.coords.x == negCamCoords){
    rigidbody.position = rigidbody.position * Time.FIxedDeltaTime * playermove.movespeed;
  }
   if (playermove.coords.y == pixelHeight){
     rigidbody.position = rigidbody.position * Time.FIxedDeltaTime * playermove.movespeed;
  }
   if (playermove.coords.y == negCamCoordsY){
     rigidbody.position = rigidbody.position * Time.FIxedDeltaTime * playermove.movespeed;
  }
  
}


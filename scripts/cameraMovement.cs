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
    rigidbody.position.x = rigidbody.position.x * Time.FIxedDeltaTime * playermove.movespeed;
  }
  if (playermove.coords.x == negCamCoords){
    rigidbody.position.x = rigidbody.position.x * Time.FIxedDeltaTime * playermove.movespeed;
  }
   if (playermove.coords.y == pixelHeight){
     rigidbody.position.y = rigidbody.position.y * Time.FIxedDeltaTime * playermove.movespeed;
  }
   if (playermove.coords.y == negCamCoordsY){
     rigidbody.position.y = rigidbody.position.y * Time.FIxedDeltaTime * playermove.movespeed;
  }
  
}


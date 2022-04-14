using system;
using UnityEngine;

public float health = 100;
new public rigidBody2D rb;
new Vector2 coords;
public Float movespeed = 3;
new public Camera main;

public class movement : Monobehavior {
	
void FixedUpdate() {
	
	float coords.y = Input.GetAxisRaw("vertical")
	float coords.x = Input.GetAxisRaw("Horizontal")
	
	transform.position = transform.position + coords(coords.x * movespeed * Time.fixedDeltaTime, coords.y * movespeed * Time.fixedDeltaTime, 0);
	
	if (main.FieldOfViewAxis.Vertical == coords.y){
		
		main.transform.position.y = main.transform.position.y * movespeed * Time.FixedDeltaTime;
		
			
	}
	if (main.FieldOfViewAxis.Horizontal == coords.x){
		
		main.transform.position.x = main.transform.position.x * movespeed * Time.FixedDeltaTime;
		
			
	}
	
	
}

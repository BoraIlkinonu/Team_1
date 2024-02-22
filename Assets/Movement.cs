using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	//float horizontalInput = 0.0f;
	float verticalInput = 0.0f;
	//Vector3 movementVector;
	//string rotationAxis;
	public float rotationInput = 15f;
	//Vector3 rotationVector;
	public float speed = 10f;
	 float rotation;

	
	private void Move()
	{
		 verticalInput = Input.GetAxis("Vertical");
		transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime, Space.Self);
		
	}

	private void Rotate()
	{
		rotation = Input.GetAxis("Horizontal");
		transform.Rotate( Vector3.up, rotation * rotationInput * Time.deltaTime);
	}

	private void Update()
	{
		Move();
		Rotate();
	}
}

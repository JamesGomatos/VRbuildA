using UnityEngine;
using System.Collections;

public class DoorScript: MonoBehaviour {

	Animator animator;


	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter (Collider collider)
	{  
		
			animator.SetBool("isOpen", true);
		
	}
		

	void OnTriggerExit(Collider collider)
	{
		animator.SetBool("isOpen", false);

	}


}﻿

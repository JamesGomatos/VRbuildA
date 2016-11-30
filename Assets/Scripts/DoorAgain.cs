using UnityEngine;
using System.Collections;

public class DoorAgain : MonoBehaviour {
	Animator animator;

	private void Awake() {
		animator = GetComponent<Animator>();
	}
		

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			animator.SetBool ("Open", true);
		}
	}

	private void OnTriggerExit(Collider other) {
			if(other.gameObject.tag == "Player") {
				animator.SetBool ("Open", false);
		}
	}
}



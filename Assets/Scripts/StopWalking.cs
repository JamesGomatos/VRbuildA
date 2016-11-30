using UnityEngine;
using System.Collections;

public class StopWalking : MonoBehaviour {
	// hold our points which is a number of empty game objects
	Animator animator;

	private void Awake() {
		animator = GetComponent<Animator>();
	}


	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Finish") {
			animator.SetBool ("Walker", true);
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Finish") {
			animator.SetBool ("Walker", false);
		}
	}
}
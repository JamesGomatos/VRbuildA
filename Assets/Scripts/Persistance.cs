using UnityEngine;
using System.Collections;

public class Persistance : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (this.gameObject);
	}
	

}

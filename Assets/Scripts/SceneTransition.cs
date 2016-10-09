using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class SceneTransition : MonoBehaviour {

	// initialize a variable
	public ScreenFader screenFader;

	public void StartGame() {
		StartCoroutine (StartTransition ());

	}

	IEnumerator StartTransition() {
		
		screenFader.fadeIn = false;
		yield return new WaitForSeconds (screenFader.fadeTime);
		SceneManager.LoadScene (1);
		screenFader.fadeIn = true;
		yield return new WaitForSeconds (screenFader.fadeTime);

	}
}

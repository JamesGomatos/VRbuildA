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
		
	public void EndGame() {
		StartCoroutine (EndTransition ());

	}

	public void TitleGame() {
		StartCoroutine (TitleTransition ());

	}


	IEnumerator StartTransition() {
		
		screenFader.fadeIn = false;
		yield return new WaitForSeconds (screenFader.fadeTime);
		// Based on Where you put the scene in build settings
		SceneManager.LoadScene (1);
		screenFader.fadeIn = true;
		yield return new WaitForSeconds (screenFader.fadeTime);

	}

	IEnumerator EndTransition() {

		screenFader.fadeIn = false;
		yield return new WaitForSeconds (screenFader.fadeTime);
		// Based on Where you put the scene in build settings
		SceneManager.LoadScene (2);
		screenFader.fadeIn = true;
		yield return new WaitForSeconds (screenFader.fadeTime);

	}

	IEnumerator TitleTransition() {

		screenFader.fadeIn = false;
		yield return new WaitForSeconds (screenFader.fadeTime);
		// Based on Where you put the scene in build settings
		SceneManager.LoadScene (0);
		screenFader.fadeIn = true;
		yield return new WaitForSeconds (screenFader.fadeTime);

	}
}

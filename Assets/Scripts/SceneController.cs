using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public Button startButton;

	// Use this for initialization
	void Start () {
		Button b = startButton.GetComponent<Button> ();
		b.onClick.AddListener (ChangeToSelectCourse);
	}
	
	void ChangeToSelectCourse() {
		SceneManager.LoadScene ("Scenes/course_select", LoadSceneMode.Single);
	}
}

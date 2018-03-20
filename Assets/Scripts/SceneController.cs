using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public Button startButton;
	public Button course1Button;
	public Button course2Button;
	public Button course3Button;
	public Button level1Button;
	public Button level2Button;
	public Button level3Button;
	public Button level4Button;
	public Button level5Button;
	public Button level6Button;
	public Button level7Button;
	public Button level8Button;
	public Button level9Button;

	// Use this for initialization
	void Start () {
		if (startButton != null) {
			Button b = startButton.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToSelectCourse);
		} else if (course1Button != null) {
			Button b = course1Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToSelectLevel);
			b = course2Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToSelectLevel);
			b = course3Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToSelectLevel);
		} else if (level1Button != null) {
			Button b = level1Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level2Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level3Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level4Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level5Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level6Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level7Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level8Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
			b = level9Button.GetComponent<Button> ();
			b.onClick.AddListener (ChangeToLevel);
		}
	}
	
	void ChangeToSelectCourse() {
		SceneManager.LoadScene ("Scenes/course_select", LoadSceneMode.Single);
	}

	void ChangeToSelectLevel() {
		SceneManager.LoadScene ("Scenes/level_select", LoadSceneMode.Single);
	}

	void ChangeToLevel() {
		SceneManager.LoadScene ("Scenes/main", LoadSceneMode.Single);
	}
}

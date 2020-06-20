using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour {

	public Animator animator;
	public Transform my3DModel;
	public Transform MyPauseButton;

	// Use this for initialization
	void Start () {
		animator = my3DModel.GetComponent<Animator> ();
	}

	public void playAnim(){
		animator.Play ("WIN00",-1,0f);
	}

	public void pauseAnim(){
		animator.speed = 0;
		MyPauseButton.GetComponentInChildren<Text> ().text = "RESUME";
		Button btn = MyPauseButton.GetComponent<Button> ();
		btn.onClick.AddListener (resumeAnim);
	}

	void resumeAnim(){
		MyPauseButton.GetComponentInChildren<Text> ().text = "PAUSE";
		animator.speed = 1;
		Button btn = MyPauseButton.GetComponent<Button> ();
		btn.onClick.AddListener (pauseAnim);
	}


}

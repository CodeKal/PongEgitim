using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour {
    // Use this for initialization
    public GameObject ResumeButton, RestartButton, ExitButton; 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickResumeButton(){
        Time.timeScale = 1f; //Oyun devam ediyor
        ResumeButton.SetActive(false);
        RestartButton.SetActive(false);
        ExitButton.SetActive(false);
        
    }
    public void OnClickRestartButton(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
    public void OnClickExitButton(){
        Application.Quit();
    }
}

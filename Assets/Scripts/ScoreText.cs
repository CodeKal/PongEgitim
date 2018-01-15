using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
    public Text ScoreLeft, ScoreRight;
	// Use this for initialization
	void Start () {
        ScoreLeft.text = "0";
        ScoreRight.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

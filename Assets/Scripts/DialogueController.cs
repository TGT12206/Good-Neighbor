using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextObject;
    [SerializeField] private TextMeshProUGUI ScoreDisplay;
    string text;
    string[] dialogue = {"Granny: Oh my gah! A truck is rolling downhill!",
            "Granny: I know what to do!",
	        "Granny: Like a good neighbor statefarm is there!",
	        "Granny: Help! That truck is gonna hit stuff!",
	        "Jake: Got it, I'll save everyone's stuff!",
	        "",
    	    "Jake: Like a good neighbor, Granny is here!",
    	    "Jake: Granny, hit the brakes!"};
    int lineNumber = -1;
    int points;
    public bool isStarted = false;
    public bool isFinished = false;
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (!isFinished && isStarted)
        {
            ChangePoints(1);
        }
        if (isFinished)
        {
            ScoreDisplay.text = "Final Score: " + points;
        }
    }
    public void NextLine()
    {
        if (lineNumber >= dialogue.Length)
        {
            return;
        }
        lineNumber++;
        text = dialogue[lineNumber];
        TextObject.text = text;
    }
    public void ChangePoints(int pts)
    {
        points += pts;
        ScoreDisplay.text = "Score: " + points;
    }
}
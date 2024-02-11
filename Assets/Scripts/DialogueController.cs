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
    Dialogue dialogue;
    int lineNumber = -1;
    int points;
    public bool isStarted = false;
    public bool isFinished = false;
    private void Start()
    {
        dialogue = JsonUtility.FromJson<Dialogue>(File.ReadAllText("Assets/Dialogue/Level1.json"));
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
        if (lineNumber >= dialogue.lines.Length)
        {
            return;
        }
        lineNumber++;
        text = dialogue.lines[lineNumber];
        TextObject.text = text;
    }
    private class Dialogue
    {
        public string[] lines;
    }
    public void ChangePoints(int pts)
    {
        points += pts;
        ScoreDisplay.text = "Score: " + points;
    }
}
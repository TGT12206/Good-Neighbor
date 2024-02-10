using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class DialogueControl : MonoBehaviour
{
    [SerializeField] private TextMeshPro TextObject;
    string text;
    string[] dialogue;
    int lineNumber;
    private void Start()
    {
        dialogue = JsonUtility.FromJson<string[]>(File.ReadAllText("Dialogue/Level1"));
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            NextLine();
        }
    }

    void NextLine()
    {
        text = dialogue[lineNumber];
        lineNumber++;
    }
}
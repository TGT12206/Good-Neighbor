using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLady : MonoBehaviour
{
    [SerializeField] DialogueController UI;
    [SerializeField] Camera cam;
    [SerializeField] GameObject player;
    int frameCount;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    private void FixedUpdate()
    {
        frameCount++;
        if (frameCount == 300)
        {
            UI.NextLine();
            UI.isStarted = true;
        }
        else if (frameCount == 250)
        {
            UI.NextLine();
        }
        else if (frameCount == 200)
        {
            UI.NextLine();
        }
        else if (frameCount == 100)
        {
            UI.NextLine();
            player.SetActive(true);
            cam.transform.SetParent(player.transform, false);
        }
        else if (frameCount == 50)
        {
            UI.NextLine();
        }
        else if (frameCount == 1)
        {
            UI.NextLine();
        }
    }
}

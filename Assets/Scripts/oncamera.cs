using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncamera : MonoBehaviour
{

    [SerializeField] private GameObject jake;
    [SerializeField] private GameObject grandma;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = grandma.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if (jake.activeSelf)
        {
            transform.position = jake.transform.position;
        } 
    }
}

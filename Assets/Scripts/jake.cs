using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jake : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed = 1;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {   
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
 
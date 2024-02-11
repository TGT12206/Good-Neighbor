using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 1;
    [SerializeField] Camera cam;
    Animator animator;
    Vector2 direction;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        cam.transform.position = transform.position + Vector3.back;
    }

    // Update is called once per frame
    void Update()
    {   
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (!(direction.x == 0 && direction.y == 0))
        {
            animator.SetBool("isWalking", true);   
        } else
        {
            animator.SetBool("isWalking", false);
        }
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
 
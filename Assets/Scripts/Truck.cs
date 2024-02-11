using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private DialogueController UI;
    Animator animator;
    [SerializeField] GameObject oldLady;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    private void FixedUpdate()
    {
        if (GetComponent<Rigidbody2D>().velocity.x <= 0)
        {
            UI.isFinished = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            UI.ChangePoints(-50);
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.name)
        {
            case "Level End Trigger":
                UI.NextLine();
                animator.SetTrigger("Poof");
                Destroy(oldLady);
                break;
            case "Truck Stop Trigger":
                UI.NextLine();
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                break;
        }
    }
}

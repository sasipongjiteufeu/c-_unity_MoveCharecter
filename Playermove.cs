using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.PlayerLoop;


public class Playermove : MonoBehaviour

{
    private float movearror;
    private float jumping;
    [SerializeField] private float jump = 0;
    [SerializeField] private float speed = 0;
    private Rigidbody2D rb; // call we will use physic

    // Start is called before the first frame update
private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // we and use physic with rb
    }

    // Update is called once per frame
private void Update ()
    {
        movearror = Input.GetAxis("Horizontal");//movearror is axis x 
        rb.velocity = new Vector2(movearror*speed,rb.velocity.y); // movement 2d axis x 

        jumping = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x,jumping * jump);

       Vector3 mousePosition = Input.mousePosition ;
       mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 diraction = new Vector2(mousePosition.x - transform.position.x , mousePosition.y - transform.position.y);
        transform.up = diraction;

    }
}

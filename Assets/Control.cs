using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour {
    
	private float speed = 3500f;
    public static Vector3 direction;
    GameObject joueur ;
    Rigidbody2D rgb2D;
    int dir = 0;

    // Use this for initialization
    void Start () {
        rgb2D = this.gameObject.GetComponent<Rigidbody2D>();
        joueur = GameObject.Find("Lonk");
    }
    // Update is called once per frame
    void Update () {
        if (direction == Vector3.up) { dir = 1; }
        if (direction == Vector3.right) { dir = 2; }
        if (direction == Vector3.down) { dir = 3; }
        if (direction == Vector3.left) { dir = 4; }
        this.GetComponent<Animator>().SetInteger("direction", dir);



        if (Logique.jouable)
        {
            if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
            {
                rgb2D.AddForce(Vector2.up * speed * Time.deltaTime);
                rgb2D.AddForce(Vector2.right * speed * Time.deltaTime);
            }
            else
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
            {
                rgb2D.AddForce(Vector2.left * speed * Time.deltaTime);
                rgb2D.AddForce(Vector2.up * speed * Time.deltaTime);
            }
            else
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                rgb2D.AddForce(Vector2.down * speed * Time.deltaTime);
                rgb2D.AddForce(Vector2.left * speed * Time.deltaTime);
            }
            else
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                rgb2D.AddForce(Vector2.down * speed * Time.deltaTime);
                rgb2D.AddForce(Vector2.right * speed * Time.deltaTime);
            }
            else
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rgb2D.AddForce(Vector2.right * speed * Time.deltaTime);
                direction = Vector3.right;
            }
            else
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rgb2D.AddForce(Vector2.left * speed * Time.deltaTime);
                direction = Vector3.left;
            }
            else
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rgb2D.AddForce(Vector2.up * speed * Time.deltaTime);
                direction = Vector3.up;
            }
            else
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rgb2D.AddForce(Vector2.down * speed * Time.deltaTime);
                direction = Vector3.down;
            }
        }
    }
}

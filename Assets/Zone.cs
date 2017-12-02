using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour {
    public GameObject go = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.name != "Lonk")
        {
            go = collision.gameObject;
            Debug.Log("coucou");
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        go = null;
    }
}

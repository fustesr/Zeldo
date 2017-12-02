using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageEsc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Logique.jouable)
            {
                this.GetComponent<SpriteRenderer>().enabled = true;
                
                Logique.jouable = false;
            }
            else if (!Logique.jouable && this.GetComponent<SpriteRenderer>().enabled == true)
            {
                this.GetComponent<SpriteRenderer>().enabled = false;

                Logique.jouable = true;
            }
        }
    }
}

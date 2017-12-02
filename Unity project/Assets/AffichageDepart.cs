using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageDepart : MonoBehaviour {
    private bool executer = true;
	// Use this for initialization
	void Start () {
        Logique.jouable = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!Logique.jouable && executer)
            {

                this.GetComponent<SpriteRenderer>().enabled = false;

                executer = false;
                Logique.jouable = true;
            }
        }
    }
}

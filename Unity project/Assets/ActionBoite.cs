using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBoite : MonoBehaviour {
    CapsuleCollider2D colliderJoueur;
    BoxCollider2D colliderBoite;
    public float smoothing = 1F;
    private GameObject other;
    private float vitesse = 6F;
    private bool bouge = false;
    private bool suit = false;
    private bool pose = false;
    private bool porte = false;

    public double distanceJoueur()
    {
        return (Vector3.Distance(transform.position, other.transform.position));
    }
    void Awake()
    {
        other = GameObject.Find("Lonk");
        colliderJoueur = other.GetComponent<CapsuleCollider2D>();
        colliderBoite = this.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        
        if (bouge)
        {
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, Time.deltaTime * vitesse / 2);
            transform.position = Vector3.Lerp(transform.position, other.transform.position, Time.deltaTime * smoothing);
            if (Vector3.Distance(transform.position,other.transform.position)<0.1)
            {
                bouge = false;
                Logique.jouable = true;
                suit = true;
            }
        }
        if (suit)
        {
            transform.position = other.transform.position;
        }

        if (pose)
        {

            suit = false;
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position +Control.direction, Time.deltaTime * vitesse / 2);
            transform.position = Vector3.Lerp(transform.position, other.transform.position + Control.direction, Time.deltaTime * smoothing);
            if (Vector3.Distance(transform.position, other.transform.position) > 0.4)
            {
                Logique.jouable = true;
                pose = false;
                colliderBoite.enabled = true;
                
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("THIS : " + this + " minObject : " +  Logique.minObject() + "comparaison : " + this.GetComponent<CubeIntObject>());
            //Debug.Log("Test bool : " + (Logique.minObject().GetComponent<CubeIntObject>() == this.GetComponent<CubeIntObject>()));


            if (porte)
            {
                porte = false;
                bouge = false;
                Logique.jouable = false;
                pose = true;
            } else if (colliderBoite.Distance(colliderJoueur).distance < 0.25 && (Logique.minObject() ==  this.gameObject))
            {
				if (this.GetComponent<CubeEnigmeObject> () != null) {
					Debug.Log ("CLEF = " + this.GetComponent<CubeEnigmeObject> ().cubeEnigme.enigme.clef);
				}
                if (!porte)
                {
                    colliderBoite.enabled = false;
                    porte = true;
                    bouge = true;
                    Logique.jouable = false;
                }
            }
        }
       
    }
}

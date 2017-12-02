using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class action : MonoBehaviour {
    public Rect r = new Rect(20,20,120,50);
    CapsuleCollider2D colliderJoueur;
    BoxCollider2D colliderPanneau;
    public static List<GameObject> textes = new List<GameObject>();
   

    void Awake()
    {

        colliderJoueur = GameObject.FindGameObjectWithTag("Joueur").GetComponent<CapsuleCollider2D>();
        colliderPanneau = this.GetComponent<BoxCollider2D>();
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Text"))
        {
            textes.Add(go);
            go.SetActive(false);
        }
}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (colliderPanneau.Distance(colliderJoueur).distance < 0.25 && colliderJoueur.gameObject.transform.position.y < this.transform.position.y && Control.direction==Vector3.up)
            {
                if (Logique.jouable)
                {
                    this.gameObject.transform.Find("TextePanneau").gameObject.GetComponent<SpriteRenderer>().enabled = true;
                   
                    

                    Logique.jouable = false;
                }else
                {

                    this.gameObject.transform.Find("TextePanneau").gameObject.GetComponent<SpriteRenderer>().enabled = false;

                    Logique.jouable = true;
                }
            }
        }
    }
}

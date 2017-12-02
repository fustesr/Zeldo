using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Logique : MonoBehaviour {
    public static List<TupleDistance> tableauDistance ;
    public static bool jouable;
    public static bool porteBoite = false;
    CapsuleCollider2D colliderJoueur;
    BoxCollider2D colliderBoite;
    public GameObject joueur;
    public GameObject objectMin;

    public static GameObject minObject()
    {
        float min = tableauDistance[0].distance;
        GameObject minObject = tableauDistance[0].go;
        foreach (TupleDistance tuple in tableauDistance)
        {
            if (tuple.distance < min)
            {
                min = tuple.distance;
                minObject = tuple.go;
            }
        }
        return minObject;
    }

    public void majDistance()
    {
        //Debug.Log("majDistance() - joueur : " + joueur + ", tableau go0 : " + tableauDistance[0].go + ", tableau distance0 : " + tableauDistance[0].distance + "nombre object tableau : " + tableauDistance.Count);
        foreach (TupleDistance tuple in tableauDistance)
        {
            Vector3 td = tuple.go.transform.position;
            Vector3 joueurV = joueur.transform.position;
            tuple.distance = Vector3.Distance( td, joueurV);
        }
    }
    private void Awake()
    {
        jouable = true;
    }
    // Use this for initialization
    void Start() {
        tableauDistance = new List<TupleDistance>();
        joueur = GameObject.Find("Lonk");
        colliderJoueur = joueur.GetComponent<CapsuleCollider2D>();

        //CubeIntObject cube =  GameObjectFactory.creerCubeInt(5,new Vector3(11.5F,-6.8F,-3.5F) );

        CubeIntObject cube1 = GameObjectFactory.creerCubeInt(1, new Vector3(-13.9F, -1.47F, -3.5F));
        CubeIntObject cube2 = GameObjectFactory.creerCubeInt(2, new Vector3(-13.9F, -3.35F, -3.5F));
        CubeIntObject cube3 = GameObjectFactory.creerCubeInt(3, new Vector3(-13.9F, -5.5F, -3.5F));
        CubeIntObject cube4 = GameObjectFactory.creerCubeInt(4, new Vector3(-13.9F, -7.5F, -3.5F));
        
        //Enigme e = new Enigme(1);
        //CubeEnigmeObject cubeE = GameObjectFactory.creerCubeEnigme(e, );*/


        //GameObject.FindObjectOfType<CubeIntObject>();
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Objet"))
        {
            if (go.GetComponent<CubeIntObject>() != null)
            {
                tableauDistance.Add(new TupleDistance(go, Vector3.Distance(go.transform.position, joueur.transform.position)));
            }
            if (go.GetComponent<CubeEnigmeObject>() != null)
            {
                tableauDistance.Add(new TupleDistance(go, Vector3.Distance(go.transform.position, joueur.transform.position)));
            }
            if (go.name.Equals("CubeSalle"))
            {
                tableauDistance.Add(new TupleDistance(go, Vector3.Distance(go.transform.position, joueur.transform.position)));
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        majDistance();
        objectMin = minObject();
    }
}

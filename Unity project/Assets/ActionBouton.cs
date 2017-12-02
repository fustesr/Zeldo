using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBouton : MonoBehaviour {
    private Vector3 spawnEnigmeVect = new Vector3(-1.3F, 1.0F, -3.5F);
    private Vector3 spawnIntVect = new Vector3(11.6F, -7.0F, -3.5F);
    private void Start()
    {

    }
    
    CapsuleCollider2D colliderJoueur;
    CircleCollider2D colliderBouton;
    void Awake()
    {
        colliderJoueur = GameObject.FindGameObjectWithTag("Joueur").GetComponent<CapsuleCollider2D>();
        colliderBouton = this.GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (colliderBouton.Distance(colliderJoueur).distance < 0.10 )
            {
                if (Logique.jouable)
                {
                    switch (this.name)
                    {
					case ("BoutonNewEnigme"):
                                 
						processBoutonNewEnigme();
                        break;
					case ("BoutonDivise7"):

						processBoutonDivise7();
                        break;
					case ("BoutonDivise10"):

						processBoutonDivise10();;
                        break;
					case ("BoutonSetClef"):

						processSetClef();
                        break;
					case ("BoutonSwap"):

						processSwap();
                        break;
					case ("BoutonGetDifficulty"):

						processGetDifficulty ();
                        break;
                    case ("BoutonTryDoor"):
                        processTryDoor();
                        break;
                    }
                }
            }
        }
    }



	private void processBoutonNewEnigme() {

		GameObject zoneRes = this.transform.parent.gameObject.transform.Find("ZoneRes").gameObject;
		GameObject zoneP1 = this.transform.parent.gameObject.transform.Find("ZoneP1").gameObject;
		GameObject zoneP2 = this.transform.parent.gameObject.transform.Find("ZoneP2").gameObject;
		Debug.Log(zoneP1);
		Debug.Log(zoneP2);
		try
		{

			if (zoneP1.GetComponent<Zone>().go == null && zoneP2.GetComponent<Zone>().go == null)
			{
				Debug.Log("e0");
				Enigme e0 = new Enigme();
				CubeEnigmeObject cubeEnigme = GameObjectFactory.creerCubeEnigme(e0, spawnEnigmeVect);

			}
			else
				if ((zoneP1.GetComponent<Zone>().go == null && zoneP2.GetComponent<Zone>().go != null) || (zoneP1.GetComponent<Zone>().go != null && zoneP2.GetComponent<Zone>().go == null))
				{
					Debug.Log("e1");
					if (zoneP2.GetComponent<Zone>().go == null)
					{
						int P1 = zoneP1.GetComponent<Zone>().go.GetComponent<CubeIntObject>().cubeInt.entier;
						Enigme e1 = new Enigme(P1);
						CubeEnigmeObject cubeEnigme = GameObjectFactory.creerCubeEnigme(e1, spawnEnigmeVect);
						Debug.Log(cubeEnigme);

					}
					else
					{
						int P2 = zoneP2.GetComponent<Zone>().go.GetComponent<CubeIntObject>().cubeInt.entier;
						Enigme e1 = new Enigme(P2);
						CubeEnigmeObject cubeEnigme = GameObjectFactory.creerCubeEnigme(e1, spawnEnigmeVect);
						Debug.Log(cubeEnigme);
					}
				}
				else
				{
					Debug.Log("e2");
					int P1 = zoneP1.GetComponent<Zone>().go.GetComponent<CubeIntObject>().cubeInt.entier;
					int P2 = zoneP2.GetComponent<Zone>().go.GetComponent<CubeIntObject>().cubeInt.entier;
					Enigme e2 = new Enigme(P1, P2);
					CubeEnigmeObject cubeEnigme = GameObjectFactory.creerCubeEnigme(e2, spawnEnigmeVect);
					Debug.Log(cubeEnigme);

				}
		}
		catch (System.Exception e)
		{
			Debug.Log(e);
		}
	}


	private void processBoutonDivise7() {

		GameObject zoneP1 = this.transform.parent.gameObject.transform.Find("ZoneP1").gameObject;
		GameObject zoneStatic = this.transform.parent.gameObject.transform.Find("ZoneStatic").gameObject;

		Debug.Log(zoneP1);

		try {

			GameObject enigmeObject = zoneP1.GetComponent<Zone>().go;
			GameObject objectStatic = zoneStatic.GetComponent<Zone>().go;

			if(objectStatic.name.Equals("CubeSalle")) {

				CubeEnigmeObject enigme = enigmeObject.GetComponent<CubeEnigmeObject>();
				Debug.Log(enigme);

				Salle1.divise7(enigme.cubeEnigme.enigme);
			}else {
				Debug.Log("On affiche pop up : ce n'est pas possible !");
			}
				

		}
		catch (System.Exception e) {
			Debug.Log (e);
		}

	}

	private void processBoutonDivise10() {

		GameObject zoneStatic = this.transform.parent.gameObject.transform.Find("ZoneStatic").gameObject;

		try {

			GameObject enigmeObject = zoneStatic.GetComponent<Zone>().go;
			CubeEnigmeObject cubeEnigmeObject = enigmeObject.GetComponent<CubeEnigmeObject>();



			cubeEnigmeObject.cubeEnigme.enigme.divise10();



		}
		catch (System.Exception e) {
			Debug.Log (e);
		}
	}


	private void processGetDifficulty() {

		GameObject zoneStatic = this.transform.parent.gameObject.transform.Find("ZoneStatic").gameObject;
		Debug.Log(zoneStatic);

		try {

			GameObject enigmeObject = zoneStatic.GetComponent<Zone>().go;
			CubeEnigmeObject cubeEnigmeObject = enigmeObject.GetComponent<CubeEnigmeObject>();

			int difficulty = cubeEnigmeObject.cubeEnigme.difficulty;

			int result = cubeEnigmeObject.cubeEnigme.enigme.getDifficulty();
			CubeIntObject cubeEnigme = GameObjectFactory.creerCubeInt(result, spawnIntVect);


		}
		catch (System.Exception e) {
			Debug.Log (e);
		}
	}


	private void processSetClef() {

		GameObject zoneP1 = this.transform.parent.gameObject.transform.Find("ZoneP1").gameObject;
		GameObject zoneStatic = this.transform.parent.gameObject.transform.Find("ZoneStatic").gameObject;

		try {

			GameObject staticObject = zoneStatic.GetComponent<Zone>().go;
			CubeEnigmeObject cubeStaticObject = staticObject.GetComponent<CubeEnigmeObject>();

			GameObject intObject = zoneP1.GetComponent<Zone>().go;
			CubeIntObject cubeIntObject = intObject.GetComponent<CubeIntObject>();

			int intKey = cubeIntObject.cubeInt.entier;

			cubeStaticObject.cubeEnigme.enigme.setClef(intKey);


		}
		catch (System.Exception e) {
			Debug.Log (e);
		}

	}



	private void processSwap() {

		GameObject zoneP1 = this.transform.parent.gameObject.transform.Find("ZoneP1").gameObject;
		GameObject zoneP2 = this.transform.parent.gameObject.transform.Find("ZoneP2").gameObject;
		GameObject zoneStatic = this.transform.parent.gameObject.transform.Find("ZoneStatic").gameObject;


		try {

			GameObject enigmeObject = zoneP1.GetComponent<Zone>().go;
			GameObject enigmeObject2 = zoneP2.GetComponent<Zone>().go;
			GameObject objectStatic = zoneStatic.GetComponent<Zone>().go;

			if(objectStatic.name.Equals("CubeSalle")) {

				CubeEnigmeObject enigme1 = enigmeObject.GetComponent<CubeEnigmeObject>();
				CubeEnigmeObject enigme2 = enigmeObject2.GetComponent<CubeEnigmeObject>();
				Debug.Log(enigme1);

				Salle1.swap(enigme1.cubeEnigme.enigme, enigme2.cubeEnigme.enigme);
			}else {
				Debug.Log("On affiche pop up : ce n'est pas possible !");
			}

		}
		catch (System.Exception e) {
			Debug.Log (e);
		}
	}


    private void processTryDoor()
    {
        GameObject zoneP1 = this.transform.parent.gameObject.transform.Find("ZoneP1").gameObject;

        try
        {

            GameObject enigmeObject = zoneP1.GetComponent<Zone>().go;

            CubeEnigmeObject enigmeFinal = enigmeObject.GetComponent<CubeEnigmeObject>();
            Debug.Log(enigmeFinal);

            Salle1.tryDoor(enigmeFinal.cubeEnigme.enigme);


        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }
    }
}

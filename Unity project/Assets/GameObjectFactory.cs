using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFactory : MonoBehaviour {

    void Start()
    {
    }
    public static CubeIntObject creerCubeInt(int i, Vector3 pos)
    {
        GameObject cube  = (GameObject)Instantiate(Resources.Load("Cube"), pos, Quaternion.identity);
        var cubeInt = cube.GetComponent<CubeIntObject>();
        cubeInt.initialize(i);
		Logique.tableauDistance.Add(new TupleDistance(cubeInt.gameObject,777));
        //CubeIntObject cube = Instantiate(instance.CubeIntPrefab, Vector3.zero,Quaternion.identity).GetComponent<CubeIntObject>();
        //cube.initialize(i);
        return cubeInt;
    }

    public static CubeEnigmeObject creerCubeEnigme(Enigme e, Vector3 pos)
    {
        GameObject cube = (GameObject)Instantiate(Resources.Load("CubeEnigme"), pos, Quaternion.identity);
        var cubeEnigme = cube.GetComponent<CubeEnigmeObject>();
        cubeEnigme.initialize(e);
        Logique.tableauDistance.Add(new TupleDistance(cubeEnigme.gameObject,777));
        //CubeIntObject cube = Instantiate(instance.CubeIntPrefab, Vector3.zero,Quaternion.identity).GetComponent<CubeIntObject>();
        //cube.initialize(i);
        return cubeEnigme;
    }


}

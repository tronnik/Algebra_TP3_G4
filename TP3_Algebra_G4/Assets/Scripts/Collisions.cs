using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public List<GameObject> objects;

    public GameObject objectToFind;

    private void Awake()
    {
        objects = new List<GameObject>();

        objectToFind = GameObject.Find("dodecahedron");

        objects.Add(objectToFind); 
        
        objectToFind = GameObject.Find("tetrahedron");

        objects.Add(objectToFind);

        objectToFind = GameObject.Find("icosahedron");

        objects.Add(objectToFind);

        objectToFind = GameObject.Find("cube");

        objects.Add(objectToFind);

    }

    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bokita : MonoBehaviour
{
    [SerializeField] GameObject bokita2;
    MeshFilter tempMeshFilter;




    // Start is called before the first frame update
    void Start()
    {
        tempMeshFilter = bokita2.GetComponentInChildren<MeshFilter>();
        Debug.Log(tempMeshFilter.mesh.vertices);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(tempMeshFilter.mesh.bounds);

    }
}

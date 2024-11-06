using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
        transform.Rotate(Vector3.right, 0, 0);
    }
}

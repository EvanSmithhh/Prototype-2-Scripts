using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MoveForward : MonoBehaviour
    
{
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves objects straight forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

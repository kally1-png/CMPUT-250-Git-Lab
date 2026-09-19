using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : AnimatedEntity
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        base.AnimationSetup();
    }

    // Update is called once per frame
    void Update()
    {
        base.AnimationUpdate();

        if (Input.GetKey(KeyCode.W)){
            transform.position += Vector3.up * Time.deltaTime* speed;
        }

        if (Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S)){
            transform.position += Vector3.down * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}

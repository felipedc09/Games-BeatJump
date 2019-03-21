using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField]
    float bpm; //bpm 

    [HideInInspector]
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        speed = bpm / 60;
    }

    // Update is called once per frame
    void Update()
    {
        speed = bpm / 60;
        run();
    }

    void run() {
        GetComponent<Rigidbody>().velocity = transform.right * speed;
    }
}

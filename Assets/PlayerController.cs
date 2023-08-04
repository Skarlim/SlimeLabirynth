using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ public float MoveSpeed = 10;
    public float TurnSpeed = 60;
    public static float Vertical, Horyzontal;

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horyzontal = Input.GetAxis("Horizontal")* TurnSpeed * Time.deltaTime;
        transform.Rotate(0, Horyzontal, 0);
        Vertical = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Translate(0, 0, Vertical);


    }
}

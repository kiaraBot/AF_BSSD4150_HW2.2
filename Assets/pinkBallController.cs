using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class pinkBallController : MonoBehaviour
{

    private float maxSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pink Ball Instantiated");
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rbPlayer = GetComponent<Rigidbody2D>();

        rbPlayer.velocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, Input.GetAxis("Vertical") * maxSpeed);
    }
}

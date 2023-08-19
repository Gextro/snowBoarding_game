using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    [SerializeField] float torqueA = 1f;
    [SerializeField] float Booster = 30f;
    [SerializeField] float breaker = 10f;
    [SerializeField] float Basespeed = 10f;
    Rigidbody2D rd2d;
    SurfaceEffector2D surfaceEffector;
    bool canMove = true;
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        surfaceEffector = FindAnyObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            Boosttoplayer();
        }
    }
    public void DisableControls()
    {
        canMove = false;
    }
    void Boosttoplayer()
    {
        if(Input.GetKey(KeyCode.W))
        {
            surfaceEffector.speed = Booster;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            surfaceEffector.speed = breaker;
        }
        else
        {
            surfaceEffector.speed = Basespeed;
        }

    }
     void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rd2d.AddTorque(torqueA);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rd2d.AddTorque(-torqueA);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    ParticleSystem gun;
    Animator anim;
    public float speed = 3;
    Vector3 iPos;
    public float velocity;

    void Start()
    {
        gun = GetComponentInChildren<ParticleSystem>();
        anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        MoveMec();
        ShootingMec();
    }
    [PlayerCounter]
    private float MoveMec()
    {
        float x = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("x", x);
        transform.position += new Vector3(x * speed * Time.deltaTime, 0, 0);
        velocity = Mathf.Abs(((transform.position - iPos) / Time.fixedDeltaTime).x) * 10;
        iPos = transform.position;
        return velocity;
    }
    [ParticleCounter]
    int ShootingMec()
    {
        if (Input.GetKeyDown(KeyCode.Space)) gun.Play();
        else if (Input.GetKeyUp(KeyCode.Space)) gun.Stop();
        return gun.particleCount;
    }
    
}

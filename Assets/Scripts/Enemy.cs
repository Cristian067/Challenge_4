using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private GameObject goal;

    private Rigidbody rb;

    [SerializeField] private float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        goal = GameObject.Find("Player Goal");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (goal.transform.position - transform.position).normalized;

        rb.AddForce(direction * speed, ForceMode.Force);
    }
}

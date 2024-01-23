using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocalP : MonoBehaviour
{
    // Start is called before the first frame update
    

    [SerializeField] private float cameraspeed = 35f;

    [SerializeField] private GameObject camera;

    private GameObject player;

    private float HorizontalInput;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        //camera.transform.position = transform.position;
        HorizontalInput = Input.GetAxis("Horizontal");


        transform.Rotate(Vector3.up, cameraspeed * HorizontalInput * Time.deltaTime);

        transform.position = player.transform.position;
    }
}

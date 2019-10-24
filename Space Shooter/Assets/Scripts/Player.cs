using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right*horizontalInput*speed*Time.deltaTime);
        transform.Translate(Vector3.up*verticalInput*speed*Time.deltaTime);
    }
}

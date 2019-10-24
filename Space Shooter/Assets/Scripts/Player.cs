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
        if(transform.position.y>=6f){
            transform.position=new Vector3(transform.position.x,6f,0);
        }
        else if(transform.position.y<=-4f){
            transform.position=new Vector3(transform.position.x,-4f,0);
        }
        if(transform.position.x>11f){
            transform.position=new Vector3(-11f,transform.position.y,0);
        }
        else if(transform.position.x<-11f){
            transform.position = new Vector3(11f, transform.position.y,0);
        }
    }
}

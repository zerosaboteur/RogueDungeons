using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed = 5; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer(){
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,playerSpeed * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.S))
       {
           transform.Translate(0,-playerSpeed * Time.deltaTime,0);
       }
       else if(Input.GetKey(KeyCode.A))
       {
           transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
       }
       else if(Input.GetKey(KeyCode.D))
       {
           transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
       }
    }
}

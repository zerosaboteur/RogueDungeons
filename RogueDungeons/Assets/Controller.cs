﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed = 2; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //simple moving controll
    void MovePlayer(){
        if(Input.GetKey(KeyCode.W)){
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
           if(hit.distance > 0.2f || hit == false){
               transform.Translate(0,playerSpeed * Time.deltaTime,0);
           }
        }
        if(Input.GetKey(KeyCode.S))
       {
           //I create array becouse first thing detected is Player
           RaycastHit2D[] hit = new RaycastHit2D[2];
           Physics2D.RaycastNonAlloc(transform.position, Vector2.down,hit);
           if(hit[1].distance > 0.9f || hit[1] == false){
               transform.Translate(0,-playerSpeed * Time.deltaTime,0);
           }
       }
       if(Input.GetKey(KeyCode.A))
       {
           RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left);
           if(hit.distance > 0.4f || hit == false){
               transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
           }
       }
       if(Input.GetKey(KeyCode.D))
       {
           RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
           Debug.Log(hit);
           if(hit.distance > 0.4f || hit == false){
               transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
           }
       }
    }
}

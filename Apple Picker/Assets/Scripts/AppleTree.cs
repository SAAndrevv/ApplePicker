﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppleTree : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 20f;
    public float chanceToChangeDirection = 0.1f;
    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        DropApple();
    }

    private void FixedUpdate() {
        if (Random.value < chanceToChangeDirection){
            speed *= -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed);
        }
        
    }
    private void DropApple(){
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    public void On_click(){
        SceneManager.LoadScene("_Scene_1");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform movePoints;
    private int randomPos;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float startTime;
    private float waitTime;
    void Start()
    {

        movePoints.position =  new Vector2(
            Random.Range(minX,maxX),
            Random.Range(minY,maxY)
        );
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            movePoints.position,
            speed * Time.deltaTime
        );
        if(Vector2.Distance(transform.position,movePoints.position) < 0.2f){
            if(waitTime <= 0){
                movePoints.position =  new Vector2(
                Random.Range(minX,maxX),
                Random.Range(minY,maxY)
                
            );
            waitTime = startTime;
            }else{
                waitTime -= Time.deltaTime;
            }
        }
    }
}

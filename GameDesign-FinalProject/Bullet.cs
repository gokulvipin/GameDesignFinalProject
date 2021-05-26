using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int maxHits;
    int timesHit;
    private Vector3 Barrel;
    

    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        Barrel = this.transform.parent.position;
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Barrel;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            transform.position = new Vector3(0, 180f, 0);
            timesHit = 0;
        }
    }

}

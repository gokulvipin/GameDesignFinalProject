using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int maxHits;
    int timesHit;
    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, 10f);
        }
    }
    private void OnCollisionEnter2D(Collision2D WALL)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
    }
}


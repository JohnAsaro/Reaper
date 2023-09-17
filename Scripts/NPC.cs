using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //instance variables
    
    public float speed = 1.5f;
    public int dirX;
    public int dirY;

    //I commented these out for now because they arent being used
    /*public float moveRate;
    private float moveCounter;*/


    public GameObject man;

    private new Rigidbody2D rigidbody2D { get { return GetComponent<Rigidbody2D>() ?? default(Rigidbody2D); } }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, man.transform.position, speed * Time.deltaTime); 
        transform.up = man.transform.position - transform.position;
    }
    private void ChangeDirection()
    {
        dirX = Random.Range(-1, 1); // -1 or 0 or 1
        dirY = Random.Range(-1, 1); // -1 or 0 or 1
    }
  
}

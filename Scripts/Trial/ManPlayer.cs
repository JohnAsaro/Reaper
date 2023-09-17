using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
   // public GameMaster gameMaster; // Reference to the GameMaster script

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, 14, 0);
            rb.velocity = new Vector2(rb.velocity.x, 8f);
        }
    }

    //public void GameOver()
    //{
    //    gameMaster.LoadGameOverScene(); // Call the LoadGameOverScene() method in the GameMaster script
    //}
}


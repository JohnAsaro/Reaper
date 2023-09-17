using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OldmanMovement : MonoBehaviour
{
    // instance varibles
    float moveSpeed = 5f;
    float dirX;
    float dirY;
    float inputHorizontal;
    float inputVertical;
    bool isFacingRight = true;
    bool jumped = false;
    int coins = 0;
    public Text _coinUI;
    public ParticleSystem moners;


    // Touchscreen input variables
    private float touchStartX;
    private float touchStartY;
    private int fingerID;
    public TouchController touchController;
    public static Boolean touchmode = false;

    public GameObject victory;
    public GameObject reaper;
    public Rigidbody2D rb;
    public AudioClip coin;
    public AudioSource alsocoin;
    public AudioClip jump;
    public AudioSource alsojump;
    public AudioClip jump2;
    private int jumpcount = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        if (Input.GetKey("1")) //For whatever reason keyboard controls break when you try to use touchscreen, so we can just have it activate
                               // with an option in the menu or something.
        {
            touchmode = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumped == false)
        {
            rb.velocity = Vector2.up * 10;
            jumped = true;
            if (jumpcount == 1)
            {
                alsojump.PlayOneShot(jump);
            }
            else
            {
                alsojump.PlayOneShot(jump2);
            }
            jumpcount++;
            jumpcount = jumpcount % 2;
        }
        if (touchmode == true)
        {
            // Check for touch input
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                float halfScreenWidth = Screen.width / 2f;

                if (touch.position.x > halfScreenWidth)
                {
                    // Move right
                    dirX = moveSpeed;
                    if(isFacingRight == false)
                    { 
                        Flip();
                    }
                }
                else
                {
                    // Move left
                    dirX = -moveSpeed;
                    if (isFacingRight == true)
                    {
                        Flip();
                    }
                }

                if (touch.phase == TouchPhase.Began && touch.position.y > Screen.height / 2f && jumped == false)
                {
                    // Jump
                    rb.velocity = Vector2.up * 10;
                    jumped = true;
                    if (jumpcount == 1)
                    {
                        alsojump.PlayOneShot(jump);
                    }
                    else
                    {
                        alsojump.PlayOneShot(jump2);
                    }
                    jumpcount++;
                    jumpcount = jumpcount % 2;
                }
            }
            else
            {
                // No touch input, stop moving
                dirX = 0;
            }
        }
    }
   public void touchactivate()
    {
        touchmode = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.gameObject.CompareTag("coin"))
            {
                Destroy(other.gameObject);
                moners.Play();
                coins++;
                _coinUI.text = coins.ToString();
                alsocoin.PlayOneShot(coin);
                if (coins == 3)
                {
                    victory.SendMessage("win", SendMessageOptions.DontRequireReceiver);
                }
            }
            //tag objects that you do not want the old man to be able to jump on with NoJump
            else if (other.gameObject.CompareTag("NoJump") || other.gameObject.CompareTag("reaper"))
            {
                jumped = true;
            }
            /*  //only use barrier tag on out walls meant to keep the player in bounds
              else if (other.gameObject.CompareTag("barrier"))
              {
                  jumped = true;

                  // Teleport the object away from the barrier by 5 
                  Vector2 direction = transform.position - other.transform.position;
                  direction.Normalize();
                  transform.position = (Vector2)transform.position + direction * 5f;

              }*/
            else
            {
                jumped = false;
                //play hit the ground sound
            }
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);

        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (inputHorizontal != 0)
        {
            rb.AddForce(new Vector2(inputHorizontal * moveSpeed, 0f));
        }

        if (inputHorizontal > 0 && !isFacingRight)
        {
            Flip();
        }

        if (inputHorizontal < 0 && isFacingRight)
        {
            Flip();
        }
    }

    // Flip sprite / animation over the x-axis
    protected void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        isFacingRight = !isFacingRight;
    }

    public void Right()
    {
        rb.AddForce(new Vector2(200f, 0f));
    }
}
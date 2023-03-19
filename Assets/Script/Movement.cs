using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Color32 c;
    public bool canMove;
    // Start is called before the first frame update
    public float moveSpeed;
    public float activeMoveSpeed;
    private Vector2 moveInput;
    public float dashSpeed;
    public float dashLength = .3f, dashCooldown = 3f;
    private float dashCounter, dashCoolCounter;
    public AudioSource sound;
    //public AudioSource bgm;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        c=GetComponent<SpriteRenderer>().color;
        activeMoveSpeed=moveSpeed;
        canMove=true;
        //sound=GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        c=GetComponent<SpriteRenderer>().color;
        //Debug.Log(c.r+" "+c.g+" "+c.b);
        if(canMove){
            if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.RightArrow)){
                GameObject.Find("Timer").GetComponent<TimerScript>().startTime=true;
                //bgm.Play();
            }
            moveInput.x = Input.GetAxisRaw("Horizontal");
            moveInput.y = Input.GetAxisRaw("Vertical");

            moveInput.Normalize();
            rb.velocity = moveInput * activeMoveSpeed;

            if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyUp(KeyCode.Space)){
                if(dashCoolCounter <=0 && dashCounter <=0){
                    GameObject.Find("Canvas").GetComponent<SkillCoolDown>().isCooldown=true;
                    activeMoveSpeed=dashSpeed;
                    dashCounter=dashLength;
                    //change layer to default
                    gameObject.layer=0;
                    gameObject.GetComponent<Animator>().SetBool("isDash",true);
                    if(c.r>20)
                        c.r-=20;
                    else c.r=0;
                    if(c.g>20)
                        c.g-=20;
                    else c.g=0;
                    if(c.b>20)
                        c.b-=20;
                    else c.b=0;
                    GetComponent<SpriteRenderer>().color=c;
                }
            }
            if(dashCounter > 0){
                dashCounter -= Time.deltaTime;
                if(dashCounter <= 0){
                    dashCoolCounter = dashCooldown;
                    activeMoveSpeed=moveSpeed;
                    //change layer to player
                    gameObject.layer=3;
                    gameObject.GetComponent<Animator>().SetBool("isDash",false);
                }
            }
            if(dashCoolCounter > 0){
                dashCoolCounter -= Time.deltaTime;
            }
        }
        //GetComponent<SpriteRenderer>().color=c;
    }
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(other.gameObject.name);
        
        if(other.gameObject.name=="Spot1"){
            sound.Play();
            if(c.r<170){
            c.r+=85;
            }
            else c.r=255;
        }
        if(other.gameObject.name=="Spot2"){
            sound.Play();
            if(c.g<170){
                c.g+=85;
            }
            else c.g=255;
        }
        if(other.gameObject.name=="Spot3"){
            sound.Play();
            if(c.b<170){
                c.b+=85;
            }
            else c.b=255;
        }
        GetComponent<SpriteRenderer>().color=c;
    }
}

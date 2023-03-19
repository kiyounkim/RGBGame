using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot1 : MonoBehaviour
{
    public GameObject gb;
    Color32 c;
    Color32 temp;
    public RBar rbar;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }

    // Update is called once per frame
    void Update()
    {
        c=gb.GetComponent<SpriteRenderer>().color;
        if(c.r<=170){
            temp.r=(byte)(c.r+85);
        }
        else temp.r=255;
        temp.g=c.g;
        temp.b=c.b;
        temp.a=c.a;
        GetComponent<SpriteRenderer>().color=temp;
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Enemy"||other.gameObject.tag=="Wall"||other.gameObject.tag=="Player"||other.gameObject.tag=="Spot"||other.gameObject.tag=="Border")
            transform.position=new Vector2(Random.Range(-22,18),Random.Range(-6,9));
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag=="Enemy"||other.gameObject.tag=="Wall"||other.gameObject.tag=="Player"||other.gameObject.tag=="Spot"||other.gameObject.tag=="Border")
            transform.position=new Vector2(Random.Range(-22,18),Random.Range(-6,9));
    }
    
}

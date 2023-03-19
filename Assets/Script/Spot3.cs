using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot3 : MonoBehaviour
{
    public GameObject gb;
    Color32 c;
    Color32 temp;
    public BBar bbar;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }

    // Update is called once per frame
    void Update()
    {
        c=gb.GetComponent<SpriteRenderer>().color;
        temp.r=c.r;
        temp.g=c.g;
        if(c.b<=170){
            temp.b=(byte)(c.b+85);
        }
        else temp.b=255;
        temp.a=c.a;
        GetComponent<SpriteRenderer>().color=temp;
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Enemy"||other.gameObject.tag=="Wall"||other.gameObject.tag=="Player"||other.gameObject.tag=="Spot"||other.gameObject.tag=="Border")
            transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag=="Enemy"||other.gameObject.tag=="Wall"||other.gameObject.tag=="Player"||other.gameObject.tag=="Spot"||other.gameObject.tag=="Border")
            transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }
}

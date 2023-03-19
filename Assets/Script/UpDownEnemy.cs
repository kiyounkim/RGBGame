using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownEnemy : MonoBehaviour
{
    int towards;
    public RBar rbar;
    public GBar gbar;
    public BBar bbar;
    Color32 c;
    // Start is called before the first frame update
    void Start()
    {
        towards=1;
    }
    void Update()
    {
        transform.Translate(towards * Vector2.up * 20 * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Border"){
            towards*=-1;
        }
        if(other.gameObject.tag=="Player"){
            //set player's color to enemy's color
            other.gameObject.GetComponent<SpriteRenderer>().color=GetComponent<SpriteRenderer>().color;
            c=other.gameObject.GetComponent<SpriteRenderer>().color;
            //rbar.setRValue((int)c.r);
            //gbar.setGValue((int)c.g);
            //bbar.setBValue((int)c.b);
        }
    }
}

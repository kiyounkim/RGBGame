using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public RBar rbar;    
    public GBar gbar;
    public BBar bbar;
    Color32 c;
    void Start()
    {
        //gameObject.GetComponent<Animator>().SetBool("canMove",true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            other.gameObject.GetComponent<SpriteRenderer>().color=GetComponent<SpriteRenderer>().color;
            c=other.gameObject.GetComponent<SpriteRenderer>().color;
            // rbar.setRValue((int)c.r);
            // gbar.setGValue((int)c.g);
            // bbar.setBValue((int)c.b);
        }
    }
}

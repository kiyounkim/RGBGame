using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackEnemy : MonoBehaviour
{
    public GameObject target;
    public RBar rbar;
    public GBar gbar;
    public BBar bbar;
    Color32 c;
    // Start is called before the first frame update
    void Start()
    {
        //set canMove to value of target's canMove
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 5 * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            //set player's color to enemy's color
            other.gameObject.GetComponent<SpriteRenderer>().color=GetComponent<SpriteRenderer>().color;
            c=other.gameObject.GetComponent<SpriteRenderer>().color;
            // rbar.setRValue((int)c.r);
            // gbar.setGValue((int)c.g);
            // bbar.setBValue((int)c.b);
        }
    }
}

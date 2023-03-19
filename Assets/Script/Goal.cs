using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject gb;
    Color32 c;
    public bool fin = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }

    // Update is called once per frame
    void Update()
    {
        c=gb.GetComponent<SpriteRenderer>().color;
        if(c.r==255&&c.g==255&&c.b==255){
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled=true;   
        }
        else{
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled=false;
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            //Debug.Log("Win");
            //get other's canMove to false
            other.GetComponent<Movement>().canMove=false;
            other.GetComponent<Rigidbody2D>().velocity=Vector2.zero;
            fin=true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        }
        if(other.gameObject.tag=="Wall"||other.gameObject.tag=="Spot"||other.gameObject.tag=="Border")
            transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            other.GetComponent<Movement>().canMove=false;
            other.GetComponent<Rigidbody2D>().velocity=Vector2.zero;
            fin=true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        }
         if(other.gameObject.tag=="Wall"||other.gameObject.tag=="Spot"||other.gameObject.tag=="Border")
            transform.position=new Vector2(Random.Range(-23,23),Random.Range(-7,9));
    }
}

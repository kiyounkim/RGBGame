using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject target;
    Color32 c;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c=target.GetComponent<SpriteRenderer>().color;
        if(c.r<80){
            //set child's SetActive to false
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
        }
        else{
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
        }
        if(c.g<80){
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else{
            transform.GetChild(1).gameObject.SetActive(true);
        }
        if(c.b<80){
            transform.GetChild(3).gameObject.SetActive(false);
        }
        else{
            transform.GetChild(3).gameObject.SetActive(true);
        }
        if(c.r>=120&&c.g>=120&&c.b>=120){
            transform.GetChild(4).gameObject.GetComponent<PolygonCollider2D>().enabled=true;
            transform.GetChild(4).gameObject.GetComponent<Animator>().speed=1;
            transform.GetChild(4).gameObject.GetComponent<SpriteRenderer>().color=new Color32(0,0,0,255);

        }
        else{
            transform.GetChild(4).gameObject.GetComponent<PolygonCollider2D>().enabled=false;
            transform.GetChild(4).gameObject.GetComponent<Animator>().speed=0;
            transform.GetChild(4).gameObject.GetComponent<SpriteRenderer>().color=new Color32(0,0,0,0);
        }
        if(GameObject.Find("Square").GetComponent<Goal>().fin){
            for(int i=0;i<5;i++){
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }      
    }
}

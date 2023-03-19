using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.name=="Enemy4"){
            Spawn();
        }
    }
    
    public void Spawn(){
        int x=UnityEngine.Random.Range(-18,18);
        int y=UnityEngine.Random.Range(-4,8);
        
        transform.position=new Vector2(x,y);
    }
}

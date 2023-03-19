using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GBar : MonoBehaviour
{
    public Slider slider;
    Color32 c;
    // Start is called before the first frame update
    void Update(){
        setGValue();
    }
    public void setGValue(){
        c=GameObject.Find("Circle").GetComponent<SpriteRenderer>().color;
        slider.value=c.g;
    }
}

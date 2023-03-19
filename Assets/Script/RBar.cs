using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RBar : MonoBehaviour
{
    public Slider slider;
    Color32 c;
    // Start is called before the first frame update
    void Update(){
        setRValue();
    }
    public void setRValue(){
        c=GameObject.Find("Circle").GetComponent<SpriteRenderer>().color;
        slider.value=c.r;
    }
}

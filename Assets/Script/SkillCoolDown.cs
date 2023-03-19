using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour
{
    public Image imageCooldown;
    public float cooldownTime = 3f;
    public bool isCooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     isCooldown=true;
        // }
        if(isCooldown){
            imageCooldown.fillAmount+=1/cooldownTime*Time.deltaTime;
        }
        if(imageCooldown.fillAmount>=1){
            isCooldown=false;
            imageCooldown.fillAmount=0;
        }
    }
}

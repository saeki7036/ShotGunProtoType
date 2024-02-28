using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEvent : MonoBehaviour
{
    [SerializeField] private GameObject LeftShot;
    [SerializeField] private GameObject RightShot;
    [SerializeField] private ConeCollider LeftCollider;
    [SerializeField] private ConeCollider RightCollider;

   
    public void NormalShot(float power,float recoil,float angle,float range,string LR)
    {
       if(LR == "L")
        {
            //Debug.Log("左売ったよ");
            LeftShot.SetActive(true);
            StartCoroutine("LeftFinishShot");
          
        }
       else if(LR == "R") 
        {
           // Debug.Log("右売ったよ");
            RightShot.SetActive(true);
            StartCoroutine("RightFinishShot");
        }
      //  Debug.Log(power+"の威力だ"+recoil+"の反動だ");
    
    }
    public void FireShot(float power, float recoil, float angle, float range, string LR)
    {
        Debug.Log(power + "の威力だ" + recoil + "の反動だ 地面が燃えてるよ");
    }

    public void ChangeBullet(float angle, float range, string LR)
    {
        if (LR == "L")
        {
            LeftCollider.SetCone(angle, range);
        }
        else if (LR == "R")
        {
            RightCollider.SetCone(angle, range);
        }
    }

    IEnumerator LeftFinishShot()
    {
        yield return new WaitForSeconds(0.04f);
        LeftShot.SetActive(false);
    }

    IEnumerator RightFinishShot()
    {
        yield return new WaitForSeconds(0.04f);
        RightShot.SetActive(false);
    }
}

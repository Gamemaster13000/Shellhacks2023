using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;



public class R : MonoBehaviour
{
    public GameObject stopSign;
    public Material goMat;
    public Material stopMat;
    public GameObject train;
    public SplineAnimate splineAnimate;
    public Vector3 newTrain;
    public bool isDestoryed = false;

   // public float initialX = 7.97;
    //public float initialY = 0;
   // public float initialZ = 0.5799999;

    public bool go = true;
    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

        


    }



    void OnCollisionEnter(Collision WhoHit)
    {
        if (WhoHit.gameObject.CompareTag("hand"))

        {

            if (!go)
            {
                stopSign.GetComponent<Renderer>().material = goMat;

                splineAnimate.MaxSpeed = 10;
                go = true;


           



            }

            else
            {


                stopSign.GetComponent<Renderer>().material = stopMat;


                splineAnimate.MaxSpeed = 0;

                go = false;





            }

        }
    }
}










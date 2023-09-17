using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour

    
{
    public GameObject dLight;
    public GameObject trainLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) || OVRInput.Get(OVRInput.RawButton.RIndexTrigger) || Input.GetKeyUp(KeyCode.B) )
        {
            if (dLight.activeSelf == true){

                dLight.SetActive(false);

                trainLight.SetActive(true);


            }

            else
            {
                dLight.SetActive(true);

                trainLight.SetActive(false);

            }
            

        }
        
    }
}

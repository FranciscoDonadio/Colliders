using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAumentaSize : MonoBehaviour
{
    bool pasa = true;
    public GameObject pared;
    private void OnTriggerEnter(Collider pared)
    {

        if (pared.transform.tag == "Portal" && pasa == true && transform.localScale == new Vector3(1f, 1f, 1f))
        {
            
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);   
            Debug.Log("Pase el portal");
           pasa = false;    
       

        }
        if(transform.localScale == new Vector3(0.5f, 0.5f, 0.5f) && pared.transform.tag == "Portal2" && pasa == false)
        {
            
            transform.localScale = new Vector3(1f, 1f, 1f);  
            Debug.Log("Volvi a pasar el portal");
            Debug.Log(pasa);
            pasa = true;
            Debug.Log("Cambio valor: ");
            Debug.Log(pasa);

        }
 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedDorada : MonoBehaviour
{
    public float startTime; 
    public void ResetTimer()
    {
        startTime = 0f;
    }

    public GameObject Dorada;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.activeSelf)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("Entra al timer");
                startTime += Time.deltaTime;

                if (startTime >= 2f)
                {
                    float randomX = Random.Range(-10f, 10f);
                    float randomY = Random.Range(-0.5f, 5f);
                    float randomZ = Random.Range(-10f, 20f);
                    transform.position = new Vector3(randomX, randomY, randomZ);
                    transform.rotation = Quaternion.Euler(randomX, randomY, randomZ);
                    Debug.Log("Reseteo timer");
                    ResetTimer();

                }
            }
           
        }
    }

  
  
}

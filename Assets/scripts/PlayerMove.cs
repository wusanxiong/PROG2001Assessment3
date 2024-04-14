using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
  

    public Text text;
    int count;
    int objectCount;
    public string targetTag = "pickup";
     GameObject end_ui;
     AudioSource audioSource;

    void Start()
    {
        end_ui = GameObject.Find("end_ui");
        end_ui.SetActive(false);
        audioSource = GameObject.Find("pickup_Audio Source").GetComponent<AudioSource>();
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(targetTag);
         objectCount = objectsWithTag.Length;
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            count++;
            audioSource.Play();
            text.text = "Count: " + count;
            Destroy(other.gameObject);
            if (count == objectCount)
            {
                end_ui.SetActive(true);
            }
        }
    }
}

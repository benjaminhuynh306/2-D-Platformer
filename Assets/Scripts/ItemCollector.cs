using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int kiwi = 0;
    [SerializeField] private Text kiwiText; 
    [SerializeField] private AudioSource collectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            collectSound.Play();
            Destroy(collision.gameObject); //removes Kiwi from screen 
            kiwi++;
            kiwiText.text = "Kiwis: " + kiwi; 
            Debug.Log("Kiwis: "+ kiwi);
        }
    }
    
}

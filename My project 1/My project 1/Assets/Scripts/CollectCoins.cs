using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{

    [SerializeField] private AudioSource CollectCoinSound;


    private void OnTriggerEnter(Collider other)
    {
       
        {
            CollectCoinSound.Play();
        }
    }   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

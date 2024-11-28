// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CollectFuel : MonoBehaviour
// {
//     private void OnTriggerEnter2D(Collider2D collision){
//         if (collision.gameObject.CompareTag("Player")){
//             FuelController.instance.FillFuel();
//             Destroy(gameObject);
//         }
//     }
// }



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFuel : MonoBehaviour
{
    [SerializeField] private AudioSource collisionSound; 
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
             
            FuelController.instance.FillFuel();
            collisionSound.Play();
            Destroy(gameObject);
        }
    }
}

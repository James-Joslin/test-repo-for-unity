using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public int rotation_rate = 0;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    private void Update() {
        transform.Rotate (0,0,rotation_rate * Time.deltaTime);
        //rotates 50 degrees per second around z axis    
    }
}

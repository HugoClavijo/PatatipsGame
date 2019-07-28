using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempodeVida : MonoBehaviour
{
    public float tiempo;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

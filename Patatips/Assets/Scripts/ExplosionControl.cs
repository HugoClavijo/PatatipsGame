using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeleteFoam", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DeleteFoam()
    {
        Destroy(gameObject);
    }

}

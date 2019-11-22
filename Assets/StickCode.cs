using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickCode : MonoBehaviour
{
    private LineRenderer LR;

    [SerializeField]
    private Transform imageTarg;
    
    [SerializeField]
    private Transform Bird;

    void Start()
    {
        LR = transform.GetComponent<LineRenderer>();
        
    }

    
    void Update()
    {
        LR.SetPosition(0,imageTarg.transform.position);
        LR.SetPosition(1,Bird.transform.position);
    }
}

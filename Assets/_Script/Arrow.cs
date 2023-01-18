using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public enum ArrowType
    {
        Up,
        Down,
        Left,
        Right,
        UpRight,
        UpLeft,
        DownRight,
        DownLeft
    }

    public ArrowType _arrowType;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

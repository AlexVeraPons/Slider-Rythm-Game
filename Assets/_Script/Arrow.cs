using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // TODO 
    // check if an arrow is entering your score area 
    // check for swipes 
    // calculate score
    
    // Start is called before the first frame update
    
    private Transform _transform;
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

    public ArrowType ArrowDirection { get; set; }

    private float _xPos { get; set; }
    private float _yPos { get; set; }

    void Start()
    {
        _transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(_xPos, _yPos);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    //Todo
    // arrow position
    // arrow spawner or have an arrow spawner

    // Start is called before the first frame update
    private Arrow[] _arrowList;
    [SerializeField] private GameObject _arrows;

    private float _screenWidth;
    private float _screenHeight;

    void Start()
    {   
        // fill the arrow list with the children of the arrows object
       for (int i = 0; i < _arrows.GetComponent<Transform>().childCount; i++)
        {
            _arrowList[i] = _arrows.GetComponent<Transform>().GetChild(i).gameObject.GetComponent<Arrow>();
        }

        // get the screen width and height
        _screenWidth = Screen.width;
        _screenHeight = Screen.height;

        // set the arrow position
        ArrowPositionSetter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ArrowPositionSetter()
    {
        // set the position of the arrows
        for (int i = 0; i < _arrowList.Length; i++)
        {
            switch (_arrowList[i].ArrowDirection)
            {
                case Arrow.ArrowType.Up:
                    break; 
                case Arrow.ArrowType.Down:
                    break;
                case Arrow.ArrowType.Left:
                    break;
                case Arrow.ArrowType.Right:
                    break;
                case Arrow.ArrowType.UpRight:
                    break;
                case Arrow.ArrowType.UpLeft:
                    break;
                case Arrow.ArrowType.DownRight:
                    break;
                case Arrow.ArrowType.DownLeft:
                    break;
                default:
                    break;  
            }
        }
    }
}

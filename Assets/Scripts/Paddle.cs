using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minPaddle = 0f;
    [SerializeField] float maxPaddle = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPosMouse = Input.mousePosition.x/Screen.width * screenWidthInUnits;
        Vector2 PaddlePos = new Vector2(transform.position.x, transform.position.y);
        PaddlePos.x = Mathf.Clamp(xPosMouse, minPaddle+1, maxPaddle-1);
        transform.position = PaddlePos;
    }
}

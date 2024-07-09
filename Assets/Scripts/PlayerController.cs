using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Local -> World
// TransformDirection
        
// World -> Local
// InverseTransformDirection



// 방향 벡터로 알 수있는것들
    // 1. 거리(크기) -> magnitude
    // 2. 실제 방향 -> normalized


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    void Start()
    {
        Managers.Input.KeyAction -= OnKeyBoard;
        Managers.Input.KeyAction += OnKeyBoard;
    }
    
    void Update()
    {
        
    }

    void OnKeyBoard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.forward);  //월드 기준
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);      // 자연스럽게 쳐다보는 방향
            // transform.Translate(Vector3.forward * Time.deltaTime * _speed);      로컬 좌표계
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            // transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            // transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            // transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }    
    }
}
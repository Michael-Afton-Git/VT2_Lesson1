using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    public Vector3 moveInputVelocity = Vector3.zero;
    public float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        move.x = moveInputVelocity.x;       // 入力の X 成分を移動の X 成分に設定
        move.z = moveInputVelocity.y;       // 入力の Y 成分を移動の Z 成分に設定

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    void OnMove( InputValue value )
    {
        Debug.Log($"move value is { value.Get() }");

        moveInputVelocity = value.Get<Vector2>();
    }
}

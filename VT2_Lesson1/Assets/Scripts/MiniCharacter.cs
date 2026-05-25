using UnityEngine;
using UnityEngine.InputSystem;

public class MiniCharacter : MonoBehaviour
{
    [Header("** Shooter Settings **")]
    public GameObject bulletPrefab;     // 弾丸のプレハブ
    public GameObject shotPoint;        // 撃ちだし座標
    public float shotForce = 10f;       // 発射の力


    [Header("** Camera Settings **")]
    
    
    private Vector2 _inputMoveValue;    // Moveの入力値
    private Vector2 _inputLookValue;    // Lookの入力値
    private float _inputAttackValue;    // Attackの入力値
    private Vector3 angles;             //キャラクターの向き(角度)

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        _inputMoveValue = value.Get<Vector2>();
    }

    void OnLook(InputValue value)
    {
        _inputLookValue = value.Get<Vector2>();
    }

    void OnAttack(InputValue value)
    {
        _inputAttackValue = value.Get<float>();
    }


    public void Look()
    { 
        angels.x += _
    
    }








}
